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
    [Route("api/CompletedCrafting")]
    [ApiController]
    public class CraftingViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public CraftingViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompletedCrafting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraftingViewModel>>> GetCompleteCraftingDiagrams()
        {
            var crafts = await PopulatAllCraftingViewModels();
            return crafts;
        }

        private async Task<List<CraftingViewModel>> PopulatAllCraftingViewModels()
        {
            var vmList = new List<CraftingViewModel>();

            if (!_memoryCache.TryGetValue("CraftingInfo", out vmList))
            {
                vmList = new List<CraftingViewModel>();
                var craftingDiagrams = await _context.CraftingDiagrams.ToListAsync();
                var craftingDiagramComponents = await _context.CraftingDiagramComponents.Include(cdc => cdc.CraftingComponent).ToListAsync();
                foreach (var diagram in craftingDiagrams)
                {
                    var vm = new CraftingViewModel
                    {
                        CraftingDiagram = diagram,
                        CraftingDiagramComponents = craftingDiagramComponents.Where(cdc => cdc.CraftingDiagramID == diagram.ID).ToList()
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("CraftingInfo", vmList);
            }
            return vmList;
        }

        private async Task<CraftingViewModel> PopulateCraftingViewModel(int id)
        {
            var vmList = new List<CraftingViewModel>();
            if (!_memoryCache.TryGetValue("CraftingInfo", out vmList))
            {
                _ = await PopulatAllCraftingViewModels();
                vmList = _memoryCache.Get("CraftingInfo") as List<CraftingViewModel>;
            }
            return vmList.Where(vm => vm.CraftingDiagram.ID == id).FirstOrDefault();
        }
    }
}