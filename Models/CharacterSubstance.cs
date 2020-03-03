using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterSubstance
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int SubstanceID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Ingredient Substance { get; set; }
    }
}
