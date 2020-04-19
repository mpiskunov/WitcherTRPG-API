using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class RitualViewModel
    {
        public Ritual Ritual { get; set; }
        public IEnumerable<RitualComponent> RitualComponents { get; set; }
    }
}
