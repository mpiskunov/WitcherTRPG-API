using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterSpell
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int SpellID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Spell Spell { get; set; }
    }
}
