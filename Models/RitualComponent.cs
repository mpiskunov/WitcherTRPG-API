using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class RitualComponent : WitcherObject
    {
        public int ID { get; set; }
        public int RitualID { get; set; }
        public string ComponentName { get; set; }
        public int? Amount { get; set; }
        public Ritual Ritual { get; set; }
    }
}
