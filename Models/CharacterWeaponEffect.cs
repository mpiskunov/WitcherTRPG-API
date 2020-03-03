using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    /// <summary>
    /// Additional CharacterWeapon Effects that are currently active.
    /// </summary>
    public class CharacterWeaponEffect
    {
        // Composite Key
        public int ID { get; set; }
        public int CharacterWeaponID { get; set; }
        public string EffectName { get; set; }
        public string EffectDescription { get; set; }
        public CharacterArmor CharacterArmor { get; set; }
    }
}
