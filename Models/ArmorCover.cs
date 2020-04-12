using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class ArmorCover : WitcherObject
    {
        public int ArmorID { get; set; }
        public ArmorClassification ArmorClassification { get; set; }
        public Armor Armor { get; set; }
    }
}
