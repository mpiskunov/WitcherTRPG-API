using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class DamageLocation : WitcherObject
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public string Roll { get; set; }
        public int Penalty { get; set; }
        public decimal DamageModifier { get; set; }
        public bool IsMonster { get; set; }
    }
}
