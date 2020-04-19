using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.Models;

namespace WitcherTRPG_API.ViewModels
{
    public class MonsterViewModel
    {
        public Monster Monster { get; set; }
        public IEnumerable<MonsterAbility> MonsterAbilities { get; set; }
        public IEnumerable<MonsterDerivedStatistic> MonsterDerivedStatistics { get; set; }
        public IEnumerable<MonsterInformation> MonsterInformations { get; set; }
        public IEnumerable<MonsterLoot> MonsterLoots { get; set; }
        public IEnumerable<MonsterSkill> MonsterSkills { get; set; }
        public IEnumerable<MonsterStatistic> MonsterStatistics { get; set; }
        public IEnumerable<MonsterVulnerability> MonsterVulnerabilities { get; set; }
        public IEnumerable<MonsterWeapon> MonsterWeapons { get; set; }
    }
}
