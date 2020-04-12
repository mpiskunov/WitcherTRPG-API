using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class MountOutfit : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Availability Availability { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
        public MountOutfitClassification MountOutfitClassification { get; set; }
        public string Effect { get; set; }
    }
}
