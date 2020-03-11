using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.Models;

namespace WitcherTRPGWebApplication.Models
{
    public class CharacterSheet
    {
        public int CharacterSheetID { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int Vigor { get; set; }
        public int ImprovementPoints { get; set; }
        public decimal Encumbrance { get; set; }
        public string Clothing { get; set; }
        public string Personality { get; set; }
        public string HairStyle { get; set; }
        public string Affectations { get; set; }
        public string ValuedPerson { get; set; }
        public string Value { get; set; }
        public string FeelingsOnPeople { get; set; }
        public int RaceID { get; set; }
        public int ProfessionID { get; set; }
        public int CampaignID { get; set; }
        //public int IntelligenceID { get; set; }
        //public int ReflexID { get; set; }
        //public int DexterityID { get; set; }
        //public int BodyID { get; set; }
        //public int SpeedID { get; set; }
        //public int EmpathyID { get; set; }
        //public int CraftID { get; set; }
        //public int WillID { get; set; }
        //public int LuckID { get; set; }
        public Race Race { get; set; }
        public Profession Profession { get; set; }
        public Campaign Campaign { get; set; }
        //public CharacterStatistic Intelligence { get; set; }
        //public CharacterStatistic Reflex { get; set; }
        //public CharacterStatistic Dexterity { get; set; }
        //public CharacterStatistic Body { get; set; }
        //public CharacterStatistic Speed { get; set; }
        //public CharacterStatistic Empathy { get; set; }
        //public CharacterStatistic Craft { get; set; }
        //public CharacterStatistic Will { get; set; }
        //public CharacterStatistic Luck { get; set; }
    }
}
