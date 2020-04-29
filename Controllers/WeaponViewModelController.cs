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
    [Route("api/CompletedWeapons")]
    [ApiController]
    public class WeaponViewModelController : ControllerBase
    {
        private readonly WitcherContext _context;
        private readonly IMemoryCache _memoryCache;

        public WeaponViewModelController(WitcherContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }

        // GET: api/CompleteProfessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponViewModel>>> GetCompletedWeapons()
        {
            var weapons = await PopulatAllWeaponsViewModels();
            return weapons;
        }

        private async Task<List<WeaponViewModel>> PopulatAllWeaponsViewModels()
        {
            var vmList = new List<WeaponViewModel>();

            if (!_memoryCache.TryGetValue("WeaponInfo", out vmList))
            {
                vmList = new List<WeaponViewModel>();
                var weapons = await _context.Weapons.ToListAsync();
                var wepEffects = await _context.WeaponEffects.ToListAsync();
                foreach (var wep in weapons)
                {
                    var vm = new WeaponViewModel
                    {
                        Weapon = wep,
                        WeaponEffects = wepEffects.Where(we => we.WeaponID == wep.ID).ToList()
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("WeaponInfo", vmList);
            }
            return vmList;
        }

        private async Task<WeaponViewModel> PopulatWeaponViewModel(int id)
        {
            var vmList = new List<WeaponViewModel>();
            if (!_memoryCache.TryGetValue("WeaponInfo", out vmList))
            {
                _ = await PopulatAllWeaponsViewModels();
                vmList = _memoryCache.Get("WeaponInfo") as List<WeaponViewModel>;
            }
            return vmList.Where(vm => vm.Weapon.ID == id).FirstOrDefault();
        }
    }
}