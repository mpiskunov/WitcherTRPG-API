using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class CharacterMutagen
    {
        public int CharacterSheetID { get; set; }
        public int MutagenID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Mutagen Mutagen { get; set; }
        public bool Deleted { get; set; }
    }
}
