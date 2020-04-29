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
    [Route("api/CompletedRituals")]
    [ApiController]
    public class RitualViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public RitualViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompletedRituals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RitualViewModel>>> GetCompleteRituals()
        {
            var rituals = await PopulatAllRitualViewModels();
            return rituals;
        }

        // GET: api/CompletedRituals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RitualViewModel>> GetRitualViewModel(int id)
        {
            var ritualViewModel = await PopulateRitualViewModel(id);

            if (ritualViewModel == null)
            {
                return NotFound();
            }

            return ritualViewModel;
        }

        private async Task<List<RitualViewModel>> PopulatAllRitualViewModels()
        {
            var vmList = new List<RitualViewModel>();

            if (!_memoryCache.TryGetValue("RitualInfo", out vmList))
            {
                vmList = new List<RitualViewModel>();
                var rituals = await _context.Rituals.ToListAsync();
                var ritualComponents = await _context.RitualComponents.ToListAsync();
                foreach (var rit in rituals)
                {
                    var vm = new RitualViewModel
                    {
                        Ritual = rit,
                        RitualComponents = ritualComponents.Where(rc => rc.RitualID == rit.ID)
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("RitualInfo", vmList);
            }
            return vmList;
        }

        private async Task<RitualViewModel> PopulateRitualViewModel(int id)
        {
            var vmList = new List<RitualViewModel>();
            if (!_memoryCache.TryGetValue("RitualInfo", out vmList))
            {
                _ = await PopulatAllRitualViewModels();
                vmList = _memoryCache.Get("RitualInfo") as List<RitualViewModel>;
            }
            return vmList.Where(vm => vm.Ritual.ID == id).FirstOrDefault();
        }
    }
}