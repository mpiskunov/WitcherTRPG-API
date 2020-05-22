using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.Controllers;
using WitcherTRPGWebApplication.Models;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.ViewModels
{
    public class AmmunitionViewModel
    {
        public Ammunition Ammunition { get; set; }
        public IEnumerable<AmmunitionEffect> AmmunitionEffects { get; set; }
        public CraftingDiagram CraftingDiagram { get; set; }
        public IEnumerable<CraftingDiagramComponent> CraftingDiagramComponents { get; set; }
    }
}
