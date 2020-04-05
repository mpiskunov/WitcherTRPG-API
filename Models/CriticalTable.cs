using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class CriticalTable
    {
        public int ID { get; set; }
        public string Roll { get; set; }
        public string RollType { get; set; }
        public string EffectTitle { get; set; }
        public string EffectDescription { get; set; }
        public string Stabilized { get; set; }
        public string Treated { get; set; }
        public CriticalWoundType CriticalWoundType { get; set; }
    }
}
