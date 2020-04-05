using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class CriticalLevel
    {
        public int ID { get; set; }
        public int BeatDefenseByValue { get; set; }
        public CriticalWoundType CriticalWoundType { get; set; }
        public int BonusDamage { get; set; }
        public MonsterAnatomyType MonsterAnatomyType { get; set; }
    }
}
