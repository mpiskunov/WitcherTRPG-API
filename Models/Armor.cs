using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Armor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StoppingPower { get; set; }
        public int DefaultReliability { get; set; }
        public string Availability { get; set; }
        public int EnhancementSlots { get; set; }
        //public int EffectPackageID { get; set; }
        public int EncumberanceValue { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        //public int ArmorCategoryID { get; set; }
        public int WeightCategoryID { get; set; }
    }
}
