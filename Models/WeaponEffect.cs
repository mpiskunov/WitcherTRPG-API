using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class WeaponEffect
    {
        public int WeaponID { get; set; }
        public int EffectID { get; set; }
        public Weapon Weapon { get; set; }
        public Effect Effect { get; set; }
        public string Value { get; set; }
    }
}
