using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterEffect
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int EffectID { get; set; }
        public int CurrentDuration { get; set; }
        public int CurrentValue { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Effect Effect { get; set; }
    }
}
