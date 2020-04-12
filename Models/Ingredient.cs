using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Ingredient : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Availability Availability { get; set; }
        public string Location { get; set; }
        public string Quantity { get; set; }
        public string ForageDC { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public int AlchemicalSubstanceID { get; set; }
        public AlchemicalSubstance AlchemicalSubstance { get; set; }
    }
}
