using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class CharacterBladeOil
    {
        public int CharacterSheetID { get; set; }
        public int BladeOilID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public BladeOil BladeOil{ get; set; }
    }
}
