using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class RacialPerk
    {
        public int ID { get; set; }
        public int RaceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Race Race { get; set; }
    }
}
