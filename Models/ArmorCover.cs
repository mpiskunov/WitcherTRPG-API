using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class ArmorCover
    {
        public int ArmorID { get; set; }
        public ArmorClassification ArmorClassification { get; set; }
        public Armor Armor { get; set; }
    }
}
