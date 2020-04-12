using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.Interfaces;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.ModelsHelper
{
    /// <summary>
    /// Component(s) used for a specific Diagram. Relationship between Diagram and it's components.
    /// </summary>
    public class CraftingDiagramComponent : WitcherObject
    {
        // Composite Key.
        public int CraftingDiagramID { get; set; }
        public int CraftingComponentID { get; set; }
        public int Amount { get; set; }
        public CraftingDiagram CraftingDiagram { get; set; }
        public CraftingComponent CraftingComponent { get; set; }
    }
}