using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class WitcherSign : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SpellTypeClassification SpellTypeClassification { get; set; }
        public string StaminaCost { get; set; }
        public string Effect { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string Defense { get; set; }
        public WitcherSignClassification WitcherSignClassification { get; set; }
    }
}
