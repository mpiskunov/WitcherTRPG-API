using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterFormulae
    {
        public int CharacterSheetID { get; set; }
        public int FormulaeID { get; set; }
        public bool RetainedByMemory { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Formulae Formulae { get; set; }
    }
}
