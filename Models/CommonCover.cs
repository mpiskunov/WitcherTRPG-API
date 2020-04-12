using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class CommonCover : WitcherObject
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int StoppingPower { get; set; }
    }
}
