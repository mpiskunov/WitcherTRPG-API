using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class BombFormulae : WitcherObject
    {
        public int ID { get; set; }
        public int BombID { get; set; }
        public int CraftDC { get; set; }
        public string Time { get; set; }
        public decimal Investment { get; set; }
        public decimal Cost { get; set; }
        public Bomb Bomb { get; set; }
    }
}
