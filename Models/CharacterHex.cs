using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterHex
    {
        public int CharacterSheetID { get; set; }
        public int HexID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Hex Hex { get; set; }
        public bool Deleted { get; set; }
    }
}
