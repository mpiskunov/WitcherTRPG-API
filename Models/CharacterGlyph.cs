using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterGlyph
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int GlyphID { get; set; }
        public int? CharacterArmorID { get; set; }
        public bool IsEquipped { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Glyph Glyph { get; set; }
        public CharacterArmor CharacterArmor { get; set; }
        public bool Deleted { get; set; }
    }
}
