using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class AmmunitionEffect
    {
        public int AmmunitionID { get; set; }
        public int EffectID { get; set; }
        public Ammunition Ammunition { get; set; }
        public Effect Effect { get; set; }
        public string Value { get; set; }
    }
}
