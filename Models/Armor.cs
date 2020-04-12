using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Armor : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StoppingPower { get; set; }
        public int DefaultReliability { get; set; }
        public Availability Availability { get; set; }
        public int EnhancementSlots { get; set; }
        public int EncumberanceValue { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public WeightClassification WeightClassification { get; set; }
    }
}
