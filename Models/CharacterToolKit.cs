using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterToolKit
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int ToolKitID { get; set; }
        public int Amount { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public ToolKit ToolKit { get; set; }
        public bool Deleted { get; set; }
    }
}
