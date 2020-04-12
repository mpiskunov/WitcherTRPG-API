using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPG_API.Models
{
    public class MonsterWeapon : WitcherObject
    {
        public int ID { get; set; }
        public int MonsterID { get; set; }
        public string Name { get; set; }
        public string Damage { get; set; }
        public string Effect { get; set; }
        public int RateOfFire { get; set; }
        public Monster Monster { get; set; }
    }
}
