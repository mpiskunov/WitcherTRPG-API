using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class CharacterWitcherDecoction
    {
        public int CharacterSheetID { get; set; }
        public int WitcherDecoctionID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public WitcherDecoction WitcherDecoction { get; set; }
    }
}
