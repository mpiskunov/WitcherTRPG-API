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
    [Route("api/CompleteAmmunition")]
    [ApiController]
    public class AmmunitionViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public AmmunitionViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompleteAmmunition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmmunitionViewModel>>> GetCompleteAmmunitions()
        {
            var ammo = await PopulateAllAmmunitionViewModels();
            return ammo;
        }

        // GET: api/CompleteAmmunition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AmmunitionViewModel>> GetMonsterViewModel(int id)
        {
            var ammoViewModel = await PopulateAmmoViewModel(id);

            if (ammoViewModel == null)
            {
                return NotFound();
            }

            return ammoViewModel;
        }

        private async Task<List<AmmunitionViewModel>> PopulateAllAmmunitionViewModels()
        {
            var vmList = new List<AmmunitionViewModel>();


            if (!_memoryCache.TryGetValue("AmmunitionInfo", out vmList))
            {
                vmList = new List<AmmunitionViewModel>();
                var ammo = await _context.Ammunitions.ToListAsync();
                var ammoEffects = await _context.AmmunitionEffects.ToListAsync();
                foreach (var am in ammo)
                {
                    var vm = new AmmunitionViewModel
                    {
                      Ammunition = am,
                      AmmunitionEffects = ammoEffects.Where(ae => ae.AmmunitionID == am.ID)
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("AmmunitionInfo", vmList);
            }
            return vmList;
        }

        private async Task<AmmunitionViewModel> PopulateAmmoViewModel(int id)
        {
            var vmList = new List<AmmunitionViewModel>();
            if (!_memoryCache.TryGetValue("AmmunitionInfo", out vmList))
            {
                _ = await PopulateAllAmmunitionViewModels();
                vmList = _memoryCache.Get("AmmunitionInfo") as List<AmmunitionViewModel>;
            }
            return vmList.Where(vm => vm.Ammunition.ID == id).FirstOrDefault();
        }
    }
}