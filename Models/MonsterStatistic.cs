using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class MonsterStatistic : WitcherObject
    {
        public int MonsterID { get; set; }
        public int StatisticID { get; set; }
        public int Value { get; set; }
        public Statistic Statistic { get; set; }
        public Monster Monster { get; set; }
    }
}
