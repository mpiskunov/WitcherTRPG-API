using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPG_API.Models
{
    public class CampaignMonster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
        public int INT { get; set; }
        public int REF { get; set; }
        public int DEX { get; set; }
        public int BODY { get; set; }
        public int SPD { get; set; }
        public int EMP { get; set; }
        public int CRA { get; set; }
        public int WILL { get; set; }
        public int LUCK { get; set; }
        public int STUN { get; set; }
        public int RUN { get; set; }
        public int LEAP { get; set; }
        public int STA { get; set; }
        public int ENC { get; set; }
        public int REC { get; set; }
        public int HP { get; set; }
        public int Vigor { get; set; }
        public bool IsDead { get; set; }
        public string CurrentLocation { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    }
}
