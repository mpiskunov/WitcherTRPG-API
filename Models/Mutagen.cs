using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPG_API.Models
{
    public class Mutagen
    {
        public int ID { get; set; }
        public string MutagenSource { get; set; }
        public string Effect { get; set; }
        public int AlchemyDC { get; set; }
        public string MinorMutation { get; set; }
        public int TypeID { get; set; }
    }
}
