using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterAmmunition
    {
        public int CharacterSheetID { get; set; }
        public int AmmunitionID { get; set; }
        public int Reliability { get; set; }
        public int Amount { get; set; }
        //public int? AdditionalEffectsID { get; set; }
        public int? AmmunitionEnhancementsID { get; set; }
        public bool IsEquipped { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Ammunition Ammunition { get; set; }
    }
}
