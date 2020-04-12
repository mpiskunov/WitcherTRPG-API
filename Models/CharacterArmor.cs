using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterArmor
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int ArmorID { get; set; }
        public int StoppingPower { get; set; }
        public int EnhancementSlotsOpen { get; set; }
        /// <summary>
        /// Weight can change when Armor Enhancements are applied.
        /// </summary>
        public decimal Weight { get; set; }
        //public int? ArmorEnhancementPackageID { get; set; }
        //public int? EffectPackageID { get; set; }
        public bool IsEquipped { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Armor Armor { get; set; }
        public bool Deleted { get; set; }
        //public EffectPackage EffectPackage { get; set; }
    }
}
