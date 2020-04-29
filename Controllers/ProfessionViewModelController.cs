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
    [Route("api/CompletedProfessions")]
    [ApiController]
    public class ProfessionViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public ProfessionViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompleteProfessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessionViewModel>>> GetCompleteProfessions()
        {
            var profession = await PopulatAllProfessionViewModels();
            return profession;
        }

        private async Task<List<ProfessionViewModel>> PopulatAllProfessionViewModels()
        {
            var vmList = new List<ProfessionViewModel>();

            if (!_memoryCache.TryGetValue("ProfessionInfo", out vmList))
            {
                vmList = new List<ProfessionViewModel>();
                var professions = await _context.Professions.ToListAsync();
                var profSkillPackages = await _context.SkillPackages.Include(sp => sp.Skill).ToListAsync();
                foreach (var prof in professions)
                {
                    var vm = new ProfessionViewModel
                    {
                        Profession = prof,
                        ProfessionSkillPackage = profSkillPackages.Where(sp => sp.ProfessionID == prof.ID).ToList()
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("ProfessionInfo", vmList);
            }
            return vmList;
        }

        private async Task<ProfessionViewModel> PopulateProfessionViewModel(int id)
        {
            var vmList = new List<ProfessionViewModel>();
            if (!_memoryCache.TryGetValue("ProfessionInfo", out vmList))
            {
                _ = await PopulatAllProfessionViewModels();
                vmList = _memoryCache.Get("ProfessionInfo") as List<ProfessionViewModel>;
            }
            return vmList.Where(vm => vm.Profession.ID == id).FirstOrDefault();
        }
    }
}