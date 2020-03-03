using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterMount_Vehicle
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int Mounts_VehicleID { get; set; }
        public int Health { get; set; }
        public int Weight { get; set; }
        public int Cost { get; set; }
        //public int? MountOutfitPackageID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Mount_Vehicle Mount_Vehicle { get; set; }
    }
}
