using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class AmmunitionViewModel
    {
        public Ammunition Ammunition { get; set; }
        public IEnumerable<AmmunitionEffect> AmmunitionEffects { get; set; }
    }
}
