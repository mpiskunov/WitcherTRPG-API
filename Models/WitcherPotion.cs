using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class WitcherPotion : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Effects { get; set; }
        public string Duration { get; set; }
        public decimal Toxicity { get; set; }
        public decimal Weight { get; set; }
    }
}
