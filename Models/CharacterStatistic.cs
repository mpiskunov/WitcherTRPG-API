using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    /// <summary>
    /// Instantiation of Statistic for the current Character.
    /// </summary>
    public class CharacterStatistic
    {
        /// <summary>
        /// CharacterSheetID is used as one part of a Composite key.
        /// </summary>
        public int CharacterSheetID { get; set; }
        /// <summary>
        /// StatisticID is used as one part of a Composite key.
        /// </summary>
        public int StatisticID { get; set; }
        public int Value { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
        public Statistic Statistic { get; set; }
    }
}
