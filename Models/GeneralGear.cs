using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class GeneralGear
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal? Weight { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public GeneralGearClassification GeneralGearClassification { get; set; }
    }
}
