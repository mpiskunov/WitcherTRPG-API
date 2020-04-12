using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.ModelsHelper
{
    /// <summary>
    /// Diagram that will be used to craft the specific component.
    /// </summary>
    public class CraftingDiagram : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CraftingDC { get; set; }
        public string Time { get; set; }
        public decimal Investment { get; set; }
        public decimal Cost { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public CraftingDiagramCategory CraftingDiagramCategory { get; set; }
        public int ObjectReferenceID { get; set; }
        public int Amount { get; set; }
    }
}
