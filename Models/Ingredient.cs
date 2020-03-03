using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Location { get; set; }
        public string Quantity { get; set; }
        public string ForageDC { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public int AlchemicalSubstanceID { get; set; }
        public AlchemicalSubstance AlchemicalSubstance { get; set; }
    }
}
