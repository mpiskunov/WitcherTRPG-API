using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class DerivedStatistic : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DerivedStatisticCategory DerivedStatisticCategory { get; set; }
    }
}
