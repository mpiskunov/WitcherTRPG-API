using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class TrapDiagramComponent
    {
        public int ID { get; set; }
        public int TrapDiagramID { get; set; }
        public int? CraftingDiagramComponentID { get; set; }
        public int? SubstanceID { get; set; }
        public int Amount { get; set; }
        public TrapDiagram TrapDiagram { get; set; }
        public CraftingDiagramComponent CraftingDiagramComponent { get; set; }
        public Ingredient Substance { get; set; }
    }
}
