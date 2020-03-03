using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterWeapon
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int WeaponID { get; set; }
        public int Reliability { get; set; }
        /// <summary>
        /// Weight can change when Weapon Enhancements are applied.
        /// </summary>
        public decimal Weight { get; set; }
        public bool IsEquipped { get; set; }
        public bool HasAmmunition { get; set; }
        // Non Existent as of right now.
        public int? WeaponEnhancementsID { get; set; }
        /// <summary>
        /// This can use the WeaponEffectPackage model to hold the additional Effects.
        /// </summary>
        //public int? AdditionalEffectsID { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Weapon Weapon { get; set; }
    }
}
