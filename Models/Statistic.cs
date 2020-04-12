using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Statistic : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatisticCategory StatisticCategory { get; set; }
    }
}
