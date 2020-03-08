using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Threat { get; set; }
        public decimal Bounty { get; set; }
        public int ArmorValue { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Environment { get; set; }
        public string Intelligence { get; set; }
        public string Organization { get; set; }
        public MonsterType MonsterType { get; set; }
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
    }
}
