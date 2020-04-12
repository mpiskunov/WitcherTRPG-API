using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class Monster : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Threat { get; set; }
        public decimal Bounty { get; set; }
        public int ArmorValue { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Environment { get; set; }
        public string Intelligence { get; set; }
        public string Organization { get; set; }
        public MonsterType MonsterType { get; set; }
   
    }
}
