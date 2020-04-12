using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class BombFormulaeComponent : WitcherObject
    {
        public int ID { get; set; }
        public int BombFormulaeID { get; set; }
        public string ComponentName { get; set; }
        public int Amount { get; set; }
        public BombFormulae BombFormulae { get; set; }
    }
}
