using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.ModelsHelper
{
    /// <summary>
    /// Diagram that will be used to craft the specific component.
    /// </summary>
    public class CraftingDiagram
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CraftingDC { get; set; }
        public string Time { get; set; }
        public decimal Investment { get; set; }
        public decimal Cost { get; set; }
        public int SkillLevelID { get; set; }
        public int CategoryID { get; set; }
        public int ObjectReferenceID { get; set; }
        public int Amount { get; set; }
    }
}
