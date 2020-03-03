using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class Spell
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? StaminaCost { get; set; }
        public string Effect { get; set; }
        public string Range { get; set; }
        public string Duration { get; set; }
        public string Defense { get; set; }
        public int SkillLevelID { get; set; }
        public int SpellCategoryID { get; set; }
    }
}
