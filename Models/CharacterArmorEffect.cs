using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterArmorEffect
    {
        public int ID { get; set; }
        public int CharacterArmorID { get; set; }
        public string EffectName { get; set; }
        public string EffectDescription { get; set; }
        public CharacterArmor CharacterArmor { get; set; }
        public bool Deleted { get; set; }
    }
}
