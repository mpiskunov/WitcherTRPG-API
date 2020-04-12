using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Effect : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
