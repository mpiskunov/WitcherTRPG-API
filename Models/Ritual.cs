using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Ritual
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StaminaCost { get; set; }
        public string Effect { get; set; }
        public string PreperationTime { get; set; }
        public string DifficultyCheck { get; set; }
        public string Duration { get; set; }
        public SpellDifficultyClassification SpellDifficultyClassification { get; set; }
    }
}
