using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class Fumble : WitcherObject
    {
        public int ID { get; set; }
        public string Roll { get; set; }
        public string RollType { get; set; }
        public string Result { get; set; }
        public FumbleType FumbleType { get; set; }

    }
}
