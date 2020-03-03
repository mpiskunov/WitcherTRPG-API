using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class AmmunitionDiagramComponent
    {
        public int ID { get; set; }
        public int AmmunitionDiagramID { get; set; }
        public int? CraftingDiagramComponentID { get; set; }
        public int? SubstanceID { get; set; }
        public int Amount { get; set; }
        public AmmunitionDiagram AmmunitionDiagram { get; set; }
        public CraftingDiagramComponent CraftingDiagramComponent { get; set; }
        public Ingredient Substance { get; set; }
    }
}
