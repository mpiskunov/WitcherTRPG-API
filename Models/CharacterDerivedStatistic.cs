using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class CharacterDerivedStatistic
    {
        public int ID { get; set; }
        public int CharacterSheetID { get; set; }
        public int DerivedStatisticID { get; set; }
        public int Value { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public DerivedStatistic DerivedStatistic { get; set; }
        public bool Deleted { get; set; }
    }
}
