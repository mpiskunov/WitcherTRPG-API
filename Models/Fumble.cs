using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPG_API.Models
{
    public class Fumble
    {
        public int ID { get; set; }
        public string RollNumber { get; set; }
        public string Description { get; set; }
        public int RollType { get; set; }
    }
}
