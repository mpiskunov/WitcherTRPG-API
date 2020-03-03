using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class ArmorEnhancementPackage
    {
        public int ID { get; set; }
        public int ArmorEnhacementPackageID { get; set; }
        public int ArmorEnhancementID { get; set; }
        public ArmorEnhancement ArmorEnhancement { get; set; }
    }
}
