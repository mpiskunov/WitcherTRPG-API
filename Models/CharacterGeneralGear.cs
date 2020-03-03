using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterGeneralGear
    {
        public int CharacterSheetID { get; set; }
        public int GeneralGearID { get; set; }
        public int? Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public GeneralGear GeneralGear { get; set; }
        // Work on items in Inventory
    }
}
