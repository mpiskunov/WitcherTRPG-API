using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class ArmorEffect
    {
        public int ArmorID { get; set; }
        public int EffectID { get; set; }
        public Armor Armor { get; set; }
        public Effect Effect { get; set; }
        public string Value { get; set; }
    }
}
