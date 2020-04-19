using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.Models;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class ProfessionViewModel
    {
        public Profession Profession { get; set; }
        public IEnumerable<ProfessionSkillPackage> ProfessionSkillPackage { get; set; }
    }
}
