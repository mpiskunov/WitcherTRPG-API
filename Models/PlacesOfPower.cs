using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class PlacesOfPower : WitcherObject
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Benefit { get; set; }
        public string Duration { get; set; }
    }
}
