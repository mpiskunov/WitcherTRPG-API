using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.ViewModels
{
    public class WeaponViewModel
    {
        public Weapon Weapon { get; set; }
        public IEnumerable<WeaponEffect> WeaponEffects { get; set; }
        public CraftingDiagram CraftingDiagram { get; set; }
        public IEnumerable<CraftingDiagramComponent> CraftingDiagramComponents { get; set; }
    }
}
