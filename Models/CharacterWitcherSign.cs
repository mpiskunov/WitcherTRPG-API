using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterWitcherSign
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int WitcherSignID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public WitcherSign WitcherSign { get; set; }
    }
}
