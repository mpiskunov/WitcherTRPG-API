using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Bomb : WitcherObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AttackType { get; set; }
        public string Range { get; set; }
        public string Damage { get; set; }
        public string Effect { get; set; }
        public decimal Weight { get; set; }
        public decimal Cost { get; set; }
    }
}
