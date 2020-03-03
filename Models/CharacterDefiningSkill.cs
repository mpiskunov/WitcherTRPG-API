using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterDefiningSkill
    {
        public int CharacterSheetID { get; set; }
        public int DefiningSkillID { get; set; }
        public int Value { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public DefiningSkill DefiningSkill { get; set; }
    }
}
