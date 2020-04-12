using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class MonsterDerivedStatistic : WitcherObject
    {
        public int MonsterID { get; set; }
        public int DerivedStatisticID { get; set; }
        public int? Value { get; set; }
        public Monster Monster { get; set; }
        public DerivedStatistic DerivedStatistic { get; set; }
    }
}
