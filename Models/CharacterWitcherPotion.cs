using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class CharacterWitcherPotion
    {
        public int CharacterSheetID { get; set; }
        public int WitcherPotionID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public WitcherPotion WitcherPotion { get; set; }
        public bool Deleted { get; set; }
    }
}
