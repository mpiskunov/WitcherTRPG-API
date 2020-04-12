using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class RangeAndTargetDC : WitcherObject
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int TargetDC { get; set; }
        public int Value { get; set; }
        public string Range { get; set; }
    }
}
