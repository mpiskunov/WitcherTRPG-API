using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Interfaces;
using WitcherTRPGWebApplication.Models;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.ViewModels
{
    public class CraftingViewModel
    {
        public CraftingDiagram CraftingDiagram { get; set; }
        public IEnumerable<CraftingDiagramComponent> CraftingDiagramComponents { get; set; }
    }
}
