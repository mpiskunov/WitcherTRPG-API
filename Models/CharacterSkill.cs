using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterSkill
    {
        // Composite Key
        public int CharacterSheetID { get; set; }
        public int SkillID { get; set; }
        public int Value { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Skill Skill { get; set; }
    }
}
