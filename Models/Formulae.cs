using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Formulae
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AlchemyDC { get; set; }
        public string Time { get; set; }
        public string Cost { get; set; }
        public SkillLevel SkillLevel { get; set; }
    }
}
