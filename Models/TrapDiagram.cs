using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class TrapDiagram
    {
        public int ID { get; set; }
        public int TrapID { get; set; }
        public int CraftDC { get; set; }
        public string Time { get; set; }
        public decimal Investment { get; set; }
        public decimal Cost { get; set; }
        public Trap Trap { get; set; }
    }
}
