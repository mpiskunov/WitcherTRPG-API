using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class EffectPackage
    {
        /// <summary>
        /// Note: Make incremental for the case of additional effects on armor/weapons.
        /// </summary>
        public int EffectPackageID { get; set; }
        public int EffectID { get; set; }
        public Effect Effect { get; set; }
    }
}
