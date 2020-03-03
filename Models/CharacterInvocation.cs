using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterInvocation
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int InvocationID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Invocation Invocation { get; set; }
    }
}
