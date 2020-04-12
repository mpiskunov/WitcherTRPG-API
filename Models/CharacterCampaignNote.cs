using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterCampaignNote
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public bool Deleted { get; set; }
    }
}
