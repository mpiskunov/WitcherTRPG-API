using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.Models;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterSheet
    {
        public int CharacterSheetID { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int ImprovementPoints { get; set; }
        public int RaceID { get; set; }
        public int ProfessionID { get; set; }
        public Race Race { get; set; }
        public Profession Profession { get; set; }
        public bool Deleted { get; set; }
    }
}
