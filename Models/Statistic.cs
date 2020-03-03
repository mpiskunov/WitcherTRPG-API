using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Statistic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatisticTypeID { get; set; }
    }
}
