﻿using System;
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

        // GET: api/CompletedWeapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeaponViewModel>>> GetCompletedWeapons()
        {
            var weapons = await PopulateAllWeaponsViewModels();
            return weapons;
        }

        // GET: api/CompletedWeapons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WeaponViewModel>> GetWeaponViewModel(int id)
        {
            var weaponViewModel = await PopulateWeaponViewModel(id);

            if (weaponViewModel == null)
            {
                return NotFound();
            }

            return weaponViewModel;
        }

        private async Task<List<WeaponViewModel>> PopulateAllWeaponsViewModels()
        {
            var vmList = new List<WeaponViewModel>();

            if (!_memoryCache.TryGetValue("WeaponInfo", out vmList))
            {
                vmList = new List<WeaponViewModel>();
                var weapons = await _context.Weapons.ToListAsync();
                var wepEffects = await _context.WeaponEffects.Include(we => we.Effect).ToListAsync();
                var craftingDiagrams = await _context.CraftingDiagrams
                        .Where(cd => cd.CraftingDiagramCategory == CraftingDiagramCategory.Weapon || 
                                    cd.CraftingDiagramCategory == CraftingDiagramCategory.ElderfolkWeapon).ToListAsync();
                var craftingDiagramComponents = await _context.CraftingDiagramComponents
                        .Include(cdc => cdc.CraftingDiagram)
                        .Include(cdc => cdc.CraftingComponent)
                        .Where(cdc => craftingDiagrams.Contains(cdc.CraftingDiagram)).ToListAsync();
                foreach (var wep in weapons)
                {
                    var vm = new WeaponViewModel
                    {
                        Weapon = wep,
                        WeaponEffects = wepEffects.Where(we => we.WeaponID == wep.ID).ToList(),
                        CraftingDiagram = craftingDiagrams.Where(cd => cd.ObjectReferenceID == wep.ID).FirstOrDefault(),
                        CraftingDiagramComponents = craftingDiagramComponents.Where(cdc => cdc.CraftingDiagramID == craftingDiagrams.Where(cd => cd.ObjectReferenceID == wep.ID).FirstOrDefault()?.ID)
                    };
                    vmList.Add(vm);
                }
                _memoryCache.Set("WeaponInfo", vmList);
            }
            return vmList;
        }

        [HttpGet("{id}")]
        private async Task<WeaponViewModel> PopulateWeaponViewModel(int id)
        {
            var vmList = new List<WeaponViewModel>();
            if (!_memoryCache.TryGetValue("WeaponInfo", out vmList))
            {
                _ = await PopulateAllWeaponsViewModels();
                vmList = _memoryCache.Get("WeaponInfo") as List<WeaponViewModel>;
            }
            return vmList.Where(vm => vm.Weapon.ID == id).FirstOrDefault();
        }
    }
}