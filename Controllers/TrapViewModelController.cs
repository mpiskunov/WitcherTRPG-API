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
    [Route("api/CompletedTraps")]
    [ApiController]
    public class TrapViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public TrapViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompleteProfessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrapViewModel>>> GetCompleteTraps()
        {
            var traps = await PopulatAllTrapsViewModels();
            return traps;
        }

        private async Task<List<TrapViewModel>> PopulatAllTrapsViewModels()
        {
            var vmList = new List<TrapViewModel>();

            if (!_memoryCache.TryGetValue("TrapInfo", out vmList))
            {
                vmList = new List<TrapViewModel>();
                var traps = await _context.Traps.ToListAsync();
                var trapDiagrams = await _context.TrapDiagrams.ToListAsync();
                var trapDiComp = await _context.TrapDiagramComponents.ToListAsync();
                foreach (var trap in traps)
                {
                    var vm = new TrapViewModel
                    {
                        Trap = trap,
                        TrapDiagram = trapDiagrams.FirstOrDefault(td => td.TrapID == trap.ID),
                        TrapDiagramComponents = trapDiComp.Where(tdc => tdc.TrapDiagram == trapDiagrams.FirstOrDefault(td => td.TrapID == trap.ID))
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("TrapInfo", vmList);
            }
            return vmList;
        }

        private async Task<TrapViewModel> PopulateTrapViewModel(int id)
        {
            var vmList = new List<TrapViewModel>();
            if (!_memoryCache.TryGetValue("TrapInfo", out vmList))
            {
                _ = await PopulatAllTrapsViewModels();
                vmList = _memoryCache.Get("TrapInfo") as List<TrapViewModel>;
            }
            return vmList.Where(vm => vm.Trap.ID == id).FirstOrDefault();
        }
    }
}