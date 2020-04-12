using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterBomb
    {
        public int CharacterSheetID { get; set; }
        public int BombID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Bomb Bomb { get; set; }
        public bool Deleted { get; set; }
    }
}
