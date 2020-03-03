using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Rune
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
    }
}
