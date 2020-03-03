using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterRitual
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int RitualID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Ritual Ritual { get; set; }
    }
}
