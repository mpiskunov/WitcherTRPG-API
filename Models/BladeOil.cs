using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class BladeOil : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Effects { get; set; }
    }
}
