using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class AlchemicalItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }
        public Availability Availability { get; set; }
    }
}
