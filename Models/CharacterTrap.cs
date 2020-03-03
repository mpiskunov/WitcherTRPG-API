using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterTrap
    {
        public int CharacterSheetID { get; set; }
        public int TrapID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Trap Trap { get; set; }
    }
}
