using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class CriticalLevel : WitcherObject
    {
        public int ID { get; set; }
        public int BeatDefenseByValue { get; set; }
        public CriticalWoundType CriticalWoundType { get; set; }
        public int BonusDamage { get; set; }
        public MonsterAnatomyType MonsterAnatomyType { get; set; }
    }
}
