using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Hex : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StaminaCost { get; set; }
        public string Effect { get; set; }
        public string Danger { get; set; }
        public string RequirementToLift { get; set; }
    }
}
