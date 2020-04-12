using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterAlchemicalItem
    {
        public int CharacterSheetID { get; set; }
        public int AlchemicalItemID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public AlchemicalItem AlchemicalItem { get; set; }
        public bool Deleted { get; set; }
    }
}
