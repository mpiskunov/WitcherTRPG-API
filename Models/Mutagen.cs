using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class Mutagen : WitcherObject
    {
        public int ID { get; set; }
        public string MutagenSource { get; set; }
        public string Effect { get; set; }
        public int AlchemyDC { get; set; }
        public string MinorMutation { get; set; }
        public MutagenType MutagenType { get; set; }
    }
}
