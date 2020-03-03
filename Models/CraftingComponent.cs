using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Interfaces
{
    /// <summary>
    /// Component that will be used for crafting diagrams.
    /// </summary>
    public class CraftingComponent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Location { get; set; }
        public string Quantity { get; set; }
        public string ForageDC { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public int CategoryID { get; set; }
        //public int ReferencedObjectID { get; set; }
    }
}
