using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class ArmorEnhancement : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public int EffectPackageID { get; set; }
        public int StoppingPower { get; set; }
        public bool BludgeoningResistant { get; set; }
        public bool SlashingResistant { get; set; }
        public bool PiercingResistant { get; set; }
        public Availability Availability { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public string Effect { get; set; }
    }
}
