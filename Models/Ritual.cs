using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Ritual
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StaminaCost { get; set; }
        public string Effect { get; set; }
        public string PreperationTime { get; set; }
        public string DifficultyCheck { get; set; }
        public string Duration { get; set; }
        //public string Components { get; set; }
        //public string AlternateComponents { get; set; }
        public int DifficultyTypeID { get; set; }
    }
}
