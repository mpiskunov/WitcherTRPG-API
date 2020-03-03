using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterRune
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int RuneID { get; set; }
        public int? CharacterWeaponID { get; set; }
        public bool IsEquipped { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Rune Rune { get; set; }
        public CharacterWeapon CharacterWeapon { get; set; }
    }
}
