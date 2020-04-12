using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterMountOutfit
    {
        public int ID { get; set; }
        public int CharacterMount_VehicleID { get; set; }
        public int MountOutfitID { get; set; }
        public CharacterMount_Vehicle CharacterMount_Vehicle { get; set; }
        public MountOutfit MountOutfit { get; set; }
        public bool Deleted { get; set; }
    }
}
