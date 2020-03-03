using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Profession
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public int DefiningSkillID { get; set; }
        public int DefaultVigorValue { get; set; }
        public int ProfessionCategoryID { get; set; }
        //public DefiningSkill DefiningSkill { get; set; }
    }
}
