using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterLifeEvent
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int Decade { get; set; }
        public string Event { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public bool Deleted { get; set; }
    }
}
