using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPG_API.Models
{
    public class Source
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsOfficial { get; set; }
    }
}
