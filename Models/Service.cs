using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Service : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string SkillBase { get; set; }
        public int GeneralGearID { get; set; }
        public GeneralGear GeneralGear { get; set; }
    }
}
