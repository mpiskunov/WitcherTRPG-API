using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class DefiningSkill : WitcherObject
    {
        public int ID { get; set; }
        public int? StatisticID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsBaseSkill { get; set; }
        public int ProfessionID { get; set; }
        public Statistic Statistic { get; set; }
        public Profession Profession { get; set; }
    }
}
