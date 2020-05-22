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
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Controllers
{
    [Route("api/CompletedArmors")]
    [ApiController]
    public class ArmorViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public ArmorViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompletedArmors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArmorViewModel>>> GetCompleteMonsters()
        {
            var armor = await PopulatAllArmorViewModels();
            return armor;
        }

        // GET: api/CompletedArmors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArmorViewModel>> GetMonsterViewModel(int id)
        {
            var armorViewModel = await PopulateArmorViewModel(id);

            if (armorViewModel == null)
            {
                return NotFound();
            }

            return armorViewModel;
        }

        private async Task<List<ArmorViewModel>> PopulatAllArmorViewModels()
        {
            var vmList = new List<ArmorViewModel>();

            if (!_memoryCache.TryGetValue("ArmorInfo", out vmList))
            {
                vmList = new List<ArmorViewModel>();
                var armors = await _context.Armors.ToListAsync();
                var armorEffects = await _context.ArmorEffects.Include(ae => ae.Effect).ToListAsync();
                var armorCovers = await _context.ArmorCovers.ToListAsync();
                var craftingDiagrams = await _context.CraftingDiagrams
                     .Where(cd => cd.CraftingDiagramCategory == CraftingDiagramCategory.Armor ||
                                 cd.CraftingDiagramCategory == CraftingDiagramCategory.ElderfolkArmor).ToListAsync();
                var craftingDiagramComponents = await _context.CraftingDiagramComponents
                        .Include(cdc => cdc.CraftingDiagram)
                        .Include(cdc => cdc.CraftingComponent)
                        .Where(cdc => craftingDiagrams.Contains(cdc.CraftingDiagram)).ToListAsync();
                foreach (var armor in armors)
                {
                    var vm = new ArmorViewModel
                    {
                        Armor = armor,
                        ArmorCovers = armorCovers.Where(ac => ac.ArmorID == armor.ID),
                        ArmorEffects = armorEffects.Where(ae => ae.ArmorID == armor.ID),
                        CraftingDiagram = craftingDiagrams.Where(cd => cd.ObjectReferenceID == armor.ID).FirstOrDefault(),
                        CraftingDiagramComponents = craftingDiagramComponents.Where(cdc => cdc.CraftingDiagramID == craftingDiagrams.Where(cd => cd.ObjectReferenceID == armor.ID).FirstOrDefault()?.ID)
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("ArmorInfo", vmList);
            }
            return vmList;
        }

        private async Task<ArmorViewModel> PopulateArmorViewModel(int id)
        {
            var vmList = new List<ArmorViewModel>();
            if (!_memoryCache.TryGetValue("ArmorInfo", out vmList))
            {
                _ = await PopulatAllArmorViewModels();
                vmList = _memoryCache.Get("ArmorInfo") as List<ArmorViewModel>;
            }
            return vmList.Where(vm => vm.Armor.ID == id).FirstOrDefault();
        }
    }
}