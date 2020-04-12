using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class TrapDiagramComponent : WitcherObject
    {
        public int ID { get; set; }
        public int TrapDiagramID { get; set; }
        public int Amount { get; set; }
        public string ComponentName { get; set; }
        public TrapDiagram TrapDiagram { get; set; }
    }
}
