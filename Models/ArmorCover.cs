using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class ArmorCover
    {
        public int ArmorID { get; set; }
        public int ArmorClassificationID { get; set; }
        public Armor Armor { get; set; }
    }
}
