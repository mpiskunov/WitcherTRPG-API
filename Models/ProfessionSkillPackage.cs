using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class ProfessionSkillPackage
    {
        // Composite Key.
        public int ProfessionID { get; set; }
        public int SkillID { get; set; }
        public Profession Profession { get; set; }
        public Skill Skill { get; set; }
    }
}
