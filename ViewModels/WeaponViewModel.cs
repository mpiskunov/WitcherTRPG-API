using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class WeaponViewModel
    {
        public Weapon Weapon { get; set; }
        public IEnumerable<WeaponEffect> WeaponEffects { get; set; }
    }
}
