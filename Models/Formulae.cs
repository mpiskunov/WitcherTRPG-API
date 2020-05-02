using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Formulae : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AlchemyDC { get; set; }
        public string Time { get; set; }
        public string Cost { get; set; }
        public AlchemySkillLevel SkillLevel { get; set; }
    }
}
