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
    [Route("api/CompletedBombs")]
    [ApiController]
    public class BombViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public BombViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompletedBomb
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BombViewModel>>> GetCompleteBombs()
        {
            var bomb = await PopulatAllBombViewModels();
            return bomb;
        }

        // GET: api/CompletedBomb/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BombViewModel>> GetBombViewModel(int id)
        {
            var BombViewModel = await PopulateBombViewModel(id);

            if (BombViewModel == null)
            {
                return NotFound();
            }

            return BombViewModel;
        }

        private async Task<List<BombViewModel>> PopulatAllBombViewModels()
        {
            var vmList = new List<BombViewModel>();

            if (!_memoryCache.TryGetValue("BombInfo", out vmList))
            {
                vmList = new List<BombViewModel>();
                var bombs = await _context.Bombs.ToListAsync();
                var bombFormulae = await _context.BombFormulaes.ToListAsync();
                var bombFormComp = await _context.BombFormulaeComponents.ToListAsync();
                foreach (var bomb in bombs)
                {
                    var vm = new BombViewModel
                    {
                        Bomb = bomb,
                        BombFormulae = bombFormulae.FirstOrDefault(bf => bf.BombID == bomb.ID),
                        BombFormulaeComponents = bombFormComp.Where(bfc => bfc.BombFormulaeID == bombFormulae.FirstOrDefault(bf => bf.BombID == bomb.ID).ID)
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("BombInfo", vmList);
            }
            return vmList;
        }

        private async Task<BombViewModel> PopulateBombViewModel(int id)
        {
            var vmList = new List<BombViewModel>();
            if (!_memoryCache.TryGetValue("BombInfo", out vmList))
            {
                _ = await PopulatAllBombViewModels();
                vmList = _memoryCache.Get("BombInfo") as List<BombViewModel>;
            }
            return vmList.Where(vm => vm.Bomb.ID == id).FirstOrDefault();
        }
    }
}