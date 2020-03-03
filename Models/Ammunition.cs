using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Ammunition
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AttackType { get; set; }
        public string Availability { get; set; }
        public int DefaultReliability { get; set; }
        //public int EffectPackageID { get; set; }
        public string Concealment { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
    }
}
