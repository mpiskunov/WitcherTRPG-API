using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Profession : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DefaultVigorValue { get; set; }
        public ProfessionCategory ProfessionCategory { get; set; }
    }
}
