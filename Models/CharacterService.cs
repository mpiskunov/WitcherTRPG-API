using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterService
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int ServiceID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Service Service { get; set; }
    }
}
