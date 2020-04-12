using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Mount_Vehicle : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Athletics { get; set; }
        public int ControlMod { get; set; }
        public string Speed { get; set; }
        public int Health { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
    }
}
