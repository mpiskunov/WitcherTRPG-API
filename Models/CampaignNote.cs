using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class CampaignNote : WitcherObject
    {
        public int ID { get; set; }
        public int CampaignID { get; set; }
        public Campaign Campaign { get; set; }
        public string Note { get; set; }
    }
}
