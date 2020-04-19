using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class BombViewModel
    {
        public Bomb Bomb { get; set; }
        public BombFormulae BombFormulae { get; set; }
        public IEnumerable<BombFormulaeComponent> BombFormulaeComponents { get; set; }
    }
}
