using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class AmmunitionDiagram
    {
        public int ID { get; set; }
        public int AmmunitionID { get; set; }
        public int CraftDC { get; set; }
        public string Time { get; set; }
        public decimal Investment { get; set; }
        public decimal Cost { get; set; }
        public Ammunition Ammunition { get; set; }
    }
}
