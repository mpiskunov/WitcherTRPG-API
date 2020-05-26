using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using WitcherTRPG_API.ViewModels;
using WitcherTRPGWebApplication.Data;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/CompletedMonsters")]
    [ApiController]
    public class MonsterViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public MonsterViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompletedMonsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MonsterViewModel>>> GetCompleteMonsters()
        {
            var monsters = await PopulateMonsterViewModels();
            return monsters;
        }

        // GET: api/CompletedMonsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterViewModel>> GetMonsterViewModel(int id)
        {
            var monsterViewModel = await PopulateMonsterViewModel(id);

            if (monsterViewModel == null)
            {
                return NotFound();
            }

            return monsterViewModel;
        }

        private async Task<List<MonsterViewModel>> PopulateMonsterViewModels()
        {
            var vmList = new List<MonsterViewModel>();

            if (!_memoryCache.TryGetValue("MonsterInfo", out vmList))
            {
                vmList = new List<MonsterViewModel>();
                var monsters = await _context.Monsters.ToListAsync();
                var monAbilities = await _context.MonsterAbilities.ToListAsync();
                var monDerStats = await _context.MonsterDerivedStatistics.Include(mon => mon.DerivedStatistic).ToListAsync();
                var monInfo = await _context.MonsterInformations.ToListAsync();
                var monLoot = await _context.MonsterLoots.ToListAsync();
                var monSkills = await _context.MonsterSkills.Include(mon => mon.Skill).ToListAsync();
                var monStat = await _context.MonsterStatistics.Include(mon => mon.Statistic).ToListAsync();
                var monVulner = await _context.MonsterVulnerabilities.ToListAsync();
                var monWeapons = await _context.MonsterWeapons.ToListAsync();
                foreach (var monster in monsters)
                {
                    var vm = new MonsterViewModel
                    {
                        Monster = monster,
                        MonsterAbilities = monAbilities.Where(ma => ma.MonsterID == monster.ID),
                        MonsterDerivedStatistics = monDerStats.Where(mdr => mdr.MonsterID == monster.ID),
                        MonsterInformations = monInfo.Where(mi => mi.MonsterID == monster.ID),
                        MonsterLoots = monLoot.Where(ml => ml.MonsterID == monster.ID),
                        MonsterSkills = monSkills.Where(ms => ms.MonsterID == monster.ID),
                        MonsterStatistics = monStat.Where(ms => ms.MonsterID == monster.ID),
                        MonsterVulnerabilities = monVulner.Where(mv => mv.MonsterID == monster.ID),
                        MonsterWeapons = monWeapons.Where(mw => mw.MonsterID == monster.ID)
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("MonsterInfo", vmList);
            }
            return vmList;
        }

        private async Task<MonsterViewModel> PopulateMonsterViewModel(int id)
        {
            var vmList = new List<MonsterViewModel>();
            if (!_memoryCache.TryGetValue("MonsterInfo", out vmList))
            {
                _ = await PopulateMonsterViewModels();
                vmList = _memoryCache.Get("MonsterInfo") as List<MonsterViewModel>;
            }
            return vmList.Where(vm => vm.Monster.ID == id).FirstOrDefault();
        }
    }
}