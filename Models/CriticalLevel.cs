using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CriticalLevel
    {
        public int ID { get; set; }
        public int BeatDefenseByValue { get; set; }
        public int CategoryID { get; set; }
        public int BonusDamage { get; set; }
    }
}
