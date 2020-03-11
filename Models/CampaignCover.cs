using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class CampaignCover
    {
        public int ID { get; set; }
        public int CampaignID { get; set; }
        public int CommonCoverID { get; set; }
        public Campaign Campaign { get; set; }
        public CommonCover CommonCover { get; set; }
        public int StoppingPower { get; set; }
        public string Location { get; set; }
        public bool Deleted { get; set; }
    }
}
