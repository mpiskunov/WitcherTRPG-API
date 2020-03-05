using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Interfaces;
using WitcherTRPGWebApplication.Models;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Data
{
    public class WitcherContext : DbContext
    {
        public WitcherContext(DbContextOptions<WitcherContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Key
            modelBuilder.Entity<ProfessionSkillPackage>()
                .HasKey(o => new { o.ProfessionID, o.SkillID });
            modelBuilder.Entity<CharacterAlchemicalItem>()
                .HasKey(o => new { o.CharacterSheetID, o.AlchemicalItemID });
            modelBuilder.Entity<CharacterAmmunition>()
                .HasKey(o => new { o.CharacterSheetID, o.AmmunitionID });
            //modelBuilder.Entity<CharacterArmor>()
            //    .HasKey(o => new { o.CharacterSheetID, o.ArmorID });
            //modelBuilder.Entity<CharacterArmorEnhancement>()
            //    .HasKey(o => new { o.CharacterSheetID, o.ArmorEnhancementID });
            modelBuilder.Entity<CharacterDefiningSkill>()
                .HasKey(o => new { o.CharacterSheetID, o.DefiningSkillID });
            //modelBuilder.Entity<CharacterEffect>()
            //    .HasKey(o => new { o.CharacterSheetID, o.EffectID });
            modelBuilder.Entity<CharacterFormulae>()
                .HasKey(o => new { o.CharacterSheetID, o.FormulaeID });
            modelBuilder.Entity<CharacterGeneralGear>()
                .HasKey(o => new { o.CharacterSheetID, o.GeneralGearID });
            modelBuilder.Entity<CharacterHex>()
                .HasKey(o => new { o.CharacterSheetID, o.HexID });
            //modelBuilder.Entity<CharacterMount_Vehicle>()
            //    .HasKey(o => new { o.CharacterSheetID, o.Mounts_VehicleID });
            modelBuilder.Entity<CharacterInvocation>()
                .HasKey(o => new { o.CharacterSheetID, o.InvocationID });
            modelBuilder.Entity<CharacterRitual>()
                .HasKey(o => new { o.CharacterSheetID, o.RitualID });
            modelBuilder.Entity<CharacterService>()
                .HasKey(o => new { o.CharacterSheetID, o.ServiceID });
            modelBuilder.Entity<CharacterSkill>()
                .HasKey(o => new { o.CharacterSheetID, o.SkillID });
            modelBuilder.Entity<CharacterSpell>()
                .HasKey(o => new { o.CharacterSheetID, o.SpellID });
            modelBuilder.Entity<CharacterStatistic>()
                .HasKey(o => new { o.CharacterSheetID, o.StatisticID });
            modelBuilder.Entity<CharacterSubstance>()
                .HasKey(o => new { o.CharacterSheetID, o.SubstanceID });
            modelBuilder.Entity<CharacterToolKit>()
                .HasKey(o => new { o.CharacterSheetID, o.ToolKitID });
            //modelBuilder.Entity<CharacterWeapon>()
            //    .HasKey(o => new { o.CharacterSheetID, o.WeaponID });
            modelBuilder.Entity<CharacterWitcherSign>()
                .HasKey(o => new { o.CharacterSheetID, o.WitcherSignID });
            //modelBuilder.Entity<FormulaeComponent>()
            //    .HasKey(o => new { o.FormulaeID, o.SubstanceID });
            modelBuilder.Entity<CraftingDiagramComponent>()
                .HasKey(o => new { o.CraftingDiagramID, o.CraftingComponentID });
            //modelBuilder.Entity<CharacterArmorEffect>()
            //    .HasKey(o => new { o.CharacterArmorID, o.EffectID });
            //modelBuilder.Entity<CharacterWeaponEffect>()
            //    .HasKey(o => new { o.CharacterWeaponID, o.EffectID });
            //modelBuilder.Entity<CharacterMountOutfit>()
            //    .HasKey(o => new { o.CharacterMount_VehicleID, o.MountOutfitID });
            modelBuilder.Entity<CharacterBomb>()
                            .HasKey(o => new { o.CharacterSheetID, o.BombID });
            modelBuilder.Entity<CharacterTrap>()
                            .HasKey(o => new { o.CharacterSheetID, o.TrapID });
            modelBuilder.Entity<ArmorCover>()
                            .HasKey(o => new { o.ArmorID, o.ArmorClassificationID });
            modelBuilder.Entity<ArmorEffect>()
                            .HasKey(o => new { o.ArmorID, o.EffectID });
            modelBuilder.Entity<WeaponEffect>()
                            .HasKey(o => new { o.WeaponID, o.EffectID });
            modelBuilder.Entity<AmmunitionEffect>()
                            .HasKey(o => new { o.AmmunitionID, o.EffectID });

        }
        public DbSet<AlchemicalItem> AlchemicalItems { get; set; }
        public DbSet<Ammunition> Ammunitions { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<ArmorEnhancement> ArmorEnhancements { get; set; }
        public DbSet<AttackModifier> AttackModifiers { get; set; }
        public DbSet<CharacterAlchemicalItem> CharacterAlchemicalItems { get; set; }
        public DbSet<CharacterAmmunition> CharacterAmmunitions { get; set; }
        public DbSet<CharacterArmor> CharacterArmors { get; set; }
        public DbSet<CharacterArmorEnhancement> CharacterArmorEnhancements { get; set; }
        public DbSet<CharacterBomb> CharacterBombs { get; set; }
        public DbSet<CharacterTrap> CharacterTraps{ get; set; }
        public DbSet<Bomb> Bombs { get; set; }
        public DbSet<CharacterArmorEffect> CharacterArmorEffects{ get; set; }
        public DbSet<CharacterWeaponEffect> CharacterWeaponEffects{ get; set; }
        public DbSet<Trap> Traps{ get; set; }
        public DbSet<Rune> Runes{ get; set; }
        public DbSet<Glyph> Glyphs{ get; set; }
        public DbSet<CharacterRune> CharacterRunes{ get; set; }
        public DbSet<CharacterGlyph> CharacterGlyphs{ get; set; }
        public DbSet<AmmunitionDiagram> AmmunitionDiagrams{ get; set; }
        public DbSet<AmmunitionDiagramComponent> AmmunitionDiagramComponents{ get; set; }
        public DbSet<BombFormulae> BombFormulaes{ get; set; }
        public DbSet<BombFormulaeComponent> BombFormulaeComponents{ get; set; }
        public DbSet<TrapDiagram> TrapDiagrams{ get; set; }
        public DbSet<TrapDiagramComponent> TrapDiagramComponents { get; set; }
        public DbSet<CharacterCampaignNote> CharacterCampaignNotes { get; set; }
        public DbSet<CharacterDefiningSkill> CharacterDefiningSkills { get; set; }
        public DbSet<CharacterEarlyLifeNote> CharacterEarlyLifeNotes { get; set; }
        public DbSet<CharacterEffect> CharacterEffects { get; set; }
        public DbSet<CharacterFormulae> CharacterFormulaes { get; set; }
        public DbSet<CharacterGeneralGear> CharacterGeneralGears { get; set; }
        public DbSet<CharacterHex> CharacterHexs { get; set; }
        public DbSet<CharacterLifeEvent> CharacterLifeEvents { get; set; }
        public DbSet<CharacterMount_Vehicle> CharacterMount_Vehicles { get; set; }
        public DbSet<CharacterNote> CharacterNotes { get; set; }
        public DbSet<CharacterInvocation> CharacterInvocations { get; set; }
        public DbSet<CharacterRitual> CharacterRituals { get; set; }
        public DbSet<CharacterService> CharacterServices { get; set; }
        public DbSet<CharacterSheet> CharacterSheets { get; set; }
        public DbSet<CharacterSkill> CharacterSkills { get; set; }
        public DbSet<CharacterSpell> CharacterSpells { get; set; }
        public DbSet<CharacterStatistic> CharacterStatistics { get; set; }
        public DbSet<CharacterSubstance> CharacterSubstances { get; set; }
        public DbSet<CharacterToolKit> CharacterToolKits { get; set; }
        public DbSet<CharacterWeapon> CharacterWeapons { get; set; }
        public DbSet<CharacterWitcherSign> CharacterWitcherSigns { get; set; }
        public DbSet<CommonCover> CommonCovers { get; set; }
        public DbSet<CraftingComponent> CraftingComponents { get; set; }
        public DbSet<CraftingDiagram> CraftingDiagrams { get; set; }
        public DbSet<CraftingDiagramComponent> CraftingDiagramComponents { get; set; }
        public DbSet<DamageLocation> DamageLocations { get; set; }
        public DbSet<DefiningSkill> DefiningSkills { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<EffectPackage> EffectPackages { get; set; }
        public DbSet<Formulae> Formulaes { get; set; }
        public DbSet<FormulaeComponent> FormulaeComponents { get; set; }
        //public DbSet<Gender> Genders { get; set; }
        public DbSet<GeneralGear> GeneralGears { get; set; }
        public DbSet<Hex> Hexs { get; set; }
        public DbSet<LightLevelModifier> LightLevelModifiers { get; set; }
        public DbSet<Mount_Vehicle> Mount_Vehicles { get; set; }
        public DbSet<MountOutfit> MountOutfits { get; set; }
        public DbSet<CharacterMountOutfit> CharacterMountOutfits { get; set; }
        public DbSet<Invocation> Invocations { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RacialPerk> RacialPerks { get; set; }
        public DbSet<RammingSizeModifier> RammingSizeModifiers { get; set; }
        public DbSet<RangeAndTargetDC> RangeAndTargetDCs { get; set; }
        public DbSet<Ritual> Rituals { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProfessionSkillPackage> SkillPackages { get; set; }
        //public DbSet<SkillValue> SkillValues { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ToolKit> ToolKits { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WitcherSign> WitcherSigns { get; set; }
        public DbSet<ArmorCover> ArmorCovers { get; set; }
        public DbSet<WeaponEffect> WeaponEffects { get; set; }
        public DbSet<ArmorEffect> ArmorEffects { get; set; }
        public DbSet<AmmunitionEffect> AmmunitionEffects { get; set; }
        public DbSet<RitualComponent> RitualComponents { get; set; }
        public DbSet<PlacesOfPower> PlacesOfPowers { get; set; }
        public DbSet<AlchemicalSubstance> AlchemicalSubstances { get; set; }
        public DbSet<CriticalLevel> CriticalLevels { get; set; }
        public DbSet<DefiningSkillLink> DefiningSkillLinks { get; set; }
        public DbSet<DefiningSkillTable> DefiningSkillTables { get; set; }
        public DbSet<WitcherTRPGWebApplication.Models.ArmorEnhancementPackage> ArmorEnhancementPackage { get; set; }
    }
}
