using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class BombFormulaeComponent
    {
        public int ID { get; set; }
        public int BombDiagramID { get; set; }
        public int? CraftingDiagramComponentID { get; set; }
        public int? SubstanceID { get; set; }
        public int Amount { get; set; }
        public BombFormulae BombFormulae { get; set; }
        public CraftingDiagramComponent CraftingDiagramComponent { get; set; }
        public Ingredient Substance { get; set; }
    }
}
