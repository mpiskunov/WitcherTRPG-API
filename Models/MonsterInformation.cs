using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class MonsterInformation : WitcherObject
    {
        public int ID { get; set; }
        public int MonsterID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Monster Monster { get; set; }
    }
}
