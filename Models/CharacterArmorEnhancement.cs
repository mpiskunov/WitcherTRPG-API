using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterArmorEnhancement
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int ArmorEnhancementID { get; set; }
        public bool IsEquipped { get; set; }
        public int? CharacterArmorID { get; set; }
        public CharacterArmor CharacterArmor { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public ArmorEnhancement ArmorEnhancement { get; set; }
        public bool Deleted { get; set; }
    }
}
