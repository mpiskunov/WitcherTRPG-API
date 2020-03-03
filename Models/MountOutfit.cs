using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class MountOutfit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Availability { get; set; }
        //public int EffectPackageID { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public int ClassificationTypeID { get; set; }
        public string Effect { get; set; }
    }
}
