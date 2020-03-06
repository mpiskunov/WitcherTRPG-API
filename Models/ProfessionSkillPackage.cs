using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class ProfessionSkillPackage
    {
        
        public int ID { get; set; }
        public int ProfessionID { get; set; }
        public string SkillName { get; set; }
        public int? SkillID { get; set; }
        public Profession Profession { get; set; }
        public Skill Skill { get; set; }
    }
}
