using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class DefiningSkillLink
    {
        public int ID { get; set; }
        public int DefiningSkillID { get; set; }
        public int? NextDefiningSkillID { get; set; }
        public string PathName { get; set; }
    }
}
