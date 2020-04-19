using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class TrapViewModel
    {
        public Trap Trap { get; set; }
        public TrapDiagram TrapDiagram { get; set; }
        public IEnumerable<TrapDiagramComponent> TrapDiagramComponents { get; set; }
    }
}
