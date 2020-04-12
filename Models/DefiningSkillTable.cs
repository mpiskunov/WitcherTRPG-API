using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class DefiningSkillTable : WitcherObject
    {
        public int ID { get; set; }
        public int DefiningSkillID { get; set; }
        public string FirstColumn { get; set; }
        public string FirstColumnValue { get; set; }
        public string SecondColumn { get; set; }
        public string SecondColumnValue { get; set; }
        public string DefiningSkillFilter { get; set; }
        public DefiningSkillTableType DefiningSkillTableType { get; set; }
        public DefiningSkill DefiningSkill { get; set; }
    }
}
