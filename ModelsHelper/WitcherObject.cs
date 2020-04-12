using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.Models;

namespace WitcherTRPG_API.ModelsHelper
{
    public class WitcherObject
    {
        public bool Deleted { get; set; }
        public int? SourceID {get;set;}
        public Source Source { get; set; }

    }
}
