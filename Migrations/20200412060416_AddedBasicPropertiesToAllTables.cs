using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedBasicPropertiesToAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EffectPackages");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CampaignNotes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CampaignNotes");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "WitcherSigns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "WitcherSigns",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "WitcherPotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "WitcherPotions",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "WitcherDecoctions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "WitcherDecoctions",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Weapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Weapons",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "WeaponEffects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "WeaponEffects",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Traps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Traps",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "TrapDiagrams",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "TrapDiagrams",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "TrapDiagramComponents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "TrapDiagramComponents",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ToolKits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "ToolKits",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Statistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Statistics",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Spells",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Spells",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Skills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Skills",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "SkillPackages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "SkillPackages",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Services",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Services",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Runes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Runes",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Rituals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Rituals",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "RitualComponents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "RitualComponents",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "RangeAndTargetDCs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "RangeAndTargetDCs",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "RammingSizeModifiers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "RammingSizeModifiers",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "RacialPerks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "RacialPerks",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Races",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Races",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Professions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Professions",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "PlacesOfPowers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "PlacesOfPowers",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Mutagens",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Mutagens",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MountOutfits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MountOutfits",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Mount_Vehicles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Mount_Vehicles",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterWeapons",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterVulnerabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterVulnerabilities",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterStatistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterStatistics",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterSkills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterSkills",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Monsters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Monsters",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterLoots",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterLoots",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterInformations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterInformations",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterDerivedStatistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterDerivedStatistics",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "MonsterAbilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "MonsterAbilities",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "LightLevelModifiers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "LightLevelModifiers",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Invocations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Invocations",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Ingredients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Ingredients",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Hexs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Hexs",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Glyphs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Glyphs",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "GeneralGears",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "GeneralGears",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Fumbles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Fumbles",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Formulaes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Formulaes",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "FormulaeComponents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "FormulaeComponents",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Effects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Effects",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DerivedStatistic",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "DerivedStatistic",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DefiningSkillTables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "DefiningSkillTables",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DefiningSkills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "DefiningSkills",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DefiningSkillLinks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "DefiningSkillLinks",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "DamageLocations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "DamageLocations",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CriticalTables",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "CriticalTables",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CriticalLevels",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "CriticalLevels",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CraftingDiagrams",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "CraftingDiagrams",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CraftingDiagramComponents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "CraftingDiagramComponents",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CraftingComponents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "CraftingComponents",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CommonCovers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "CommonCovers",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Bombs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Bombs",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "BombFormulaes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "BombFormulaes",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "BombFormulaeComponents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "BombFormulaeComponents",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "BladeOils",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "BladeOils",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "AttackModifiers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "AttackModifiers",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Armors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Armors",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ArmorEnhancements",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "ArmorEnhancements",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ArmorEffects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "ArmorEffects",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ArmorCovers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "ArmorCovers",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Ammunitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "Ammunitions",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "AmmunitionEffects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "AmmunitionEffects",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "AlchemicalSubstances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "AlchemicalSubstances",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "AlchemicalItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SourceID",
                table: "AlchemicalItems",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_WitcherSigns_SourceID",
                table: "WitcherSigns",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WitcherPotions_SourceID",
                table: "WitcherPotions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WitcherDecoctions_SourceID",
                table: "WitcherDecoctions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_SourceID",
                table: "Weapons",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponEffects_SourceID",
                table: "WeaponEffects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Traps_SourceID",
                table: "Traps",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagrams_SourceID",
                table: "TrapDiagrams",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_SourceID",
                table: "TrapDiagramComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ToolKits_SourceID",
                table: "ToolKits",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_SourceID",
                table: "Statistics",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SourceID",
                table: "Spells",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SourceID",
                table: "Skills",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPackages_SourceID",
                table: "SkillPackages",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SourceID",
                table: "Services",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Runes_SourceID",
                table: "Runes",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Rituals_SourceID",
                table: "Rituals",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RitualComponents_SourceID",
                table: "RitualComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RangeAndTargetDCs_SourceID",
                table: "RangeAndTargetDCs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RammingSizeModifiers_SourceID",
                table: "RammingSizeModifiers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RacialPerks_SourceID",
                table: "RacialPerks",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SourceID",
                table: "Races",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_SourceID",
                table: "Professions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesOfPowers_SourceID",
                table: "PlacesOfPowers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Mutagens_SourceID",
                table: "Mutagens",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MountOutfits_SourceID",
                table: "MountOutfits",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Mount_Vehicles_SourceID",
                table: "Mount_Vehicles",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeapons_SourceID",
                table: "MonsterWeapons",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterVulnerabilities_SourceID",
                table: "MonsterVulnerabilities",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterStatistics_SourceID",
                table: "MonsterStatistics",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkills_SourceID",
                table: "MonsterSkills",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_SourceID",
                table: "Monsters",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoots_SourceID",
                table: "MonsterLoots",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterInformations_SourceID",
                table: "MonsterInformations",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterDerivedStatistics_SourceID",
                table: "MonsterDerivedStatistics",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAbilities_SourceID",
                table: "MonsterAbilities",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_LightLevelModifiers_SourceID",
                table: "LightLevelModifiers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Invocations_SourceID",
                table: "Invocations",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_SourceID",
                table: "Ingredients",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Hexs_SourceID",
                table: "Hexs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Glyphs_SourceID",
                table: "Glyphs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralGears_SourceID",
                table: "GeneralGears",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Fumbles_SourceID",
                table: "Fumbles",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Formulaes_SourceID",
                table: "Formulaes",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaeComponents_SourceID",
                table: "FormulaeComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_SourceID",
                table: "Effects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DerivedStatistic_SourceID",
                table: "DerivedStatistic",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkillTables_SourceID",
                table: "DefiningSkillTables",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_SourceID",
                table: "DefiningSkills",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkillLinks_SourceID",
                table: "DefiningSkillLinks",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageLocations_SourceID",
                table: "DamageLocations",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CriticalTables_SourceID",
                table: "CriticalTables",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CriticalLevels_SourceID",
                table: "CriticalLevels",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingDiagrams_SourceID",
                table: "CraftingDiagrams",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingDiagramComponents_SourceID",
                table: "CraftingDiagramComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingComponents_SourceID",
                table: "CraftingComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CommonCovers_SourceID",
                table: "CommonCovers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Bombs_SourceID",
                table: "Bombs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaes_SourceID",
                table: "BombFormulaes",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_SourceID",
                table: "BombFormulaeComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_BladeOils_SourceID",
                table: "BladeOils",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AttackModifiers_SourceID",
                table: "AttackModifiers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_SourceID",
                table: "Armors",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEnhancements_SourceID",
                table: "ArmorEnhancements",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEffects_SourceID",
                table: "ArmorEffects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorCovers_SourceID",
                table: "ArmorCovers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ammunitions_SourceID",
                table: "Ammunitions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionEffects_SourceID",
                table: "AmmunitionEffects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AlchemicalSubstances_SourceID",
                table: "AlchemicalSubstances",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AlchemicalItems_SourceID",
                table: "AlchemicalItems",
                column: "SourceID");

            migrationBuilder.AddForeignKey(
                name: "FK_AlchemicalItems_Sources_SourceID",
                table: "AlchemicalItems",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlchemicalSubstances_Sources_SourceID",
                table: "AlchemicalSubstances",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionEffects_Sources_SourceID",
                table: "AmmunitionEffects",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ammunitions_Sources_SourceID",
                table: "Ammunitions",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorCovers_Sources_SourceID",
                table: "ArmorCovers",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorEffects_Sources_SourceID",
                table: "ArmorEffects",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorEnhancements_Sources_SourceID",
                table: "ArmorEnhancements",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_Sources_SourceID",
                table: "Armors",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttackModifiers_Sources_SourceID",
                table: "AttackModifiers",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BladeOils_Sources_SourceID",
                table: "BladeOils",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BombFormulaeComponents_Sources_SourceID",
                table: "BombFormulaeComponents",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BombFormulaes_Sources_SourceID",
                table: "BombFormulaes",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bombs_Sources_SourceID",
                table: "Bombs",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommonCovers_Sources_SourceID",
                table: "CommonCovers",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CraftingComponents_Sources_SourceID",
                table: "CraftingComponents",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CraftingDiagramComponents_Sources_SourceID",
                table: "CraftingDiagramComponents",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CraftingDiagrams_Sources_SourceID",
                table: "CraftingDiagrams",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CriticalLevels_Sources_SourceID",
                table: "CriticalLevels",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CriticalTables_Sources_SourceID",
                table: "CriticalTables",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DamageLocations_Sources_SourceID",
                table: "DamageLocations",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefiningSkillLinks_Sources_SourceID",
                table: "DefiningSkillLinks",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefiningSkills_Sources_SourceID",
                table: "DefiningSkills",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefiningSkillTables_Sources_SourceID",
                table: "DefiningSkillTables",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DerivedStatistic_Sources_SourceID",
                table: "DerivedStatistic",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Effects_Sources_SourceID",
                table: "Effects",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FormulaeComponents_Sources_SourceID",
                table: "FormulaeComponents",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Formulaes_Sources_SourceID",
                table: "Formulaes",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fumbles_Sources_SourceID",
                table: "Fumbles",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralGears_Sources_SourceID",
                table: "GeneralGears",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Glyphs_Sources_SourceID",
                table: "Glyphs",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hexs_Sources_SourceID",
                table: "Hexs",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Sources_SourceID",
                table: "Ingredients",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invocations_Sources_SourceID",
                table: "Invocations",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LightLevelModifiers_Sources_SourceID",
                table: "LightLevelModifiers",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterAbilities_Sources_SourceID",
                table: "MonsterAbilities",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterDerivedStatistics_Sources_SourceID",
                table: "MonsterDerivedStatistics",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterInformations_Sources_SourceID",
                table: "MonsterInformations",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterLoots_Sources_SourceID",
                table: "MonsterLoots",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Sources_SourceID",
                table: "Monsters",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterSkills_Sources_SourceID",
                table: "MonsterSkills",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterStatistics_Sources_SourceID",
                table: "MonsterStatistics",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterVulnerabilities_Sources_SourceID",
                table: "MonsterVulnerabilities",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonsterWeapons_Sources_SourceID",
                table: "MonsterWeapons",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mount_Vehicles_Sources_SourceID",
                table: "Mount_Vehicles",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MountOutfits_Sources_SourceID",
                table: "MountOutfits",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mutagens_Sources_SourceID",
                table: "Mutagens",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacesOfPowers_Sources_SourceID",
                table: "PlacesOfPowers",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Professions_Sources_SourceID",
                table: "Professions",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Sources_SourceID",
                table: "Races",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RacialPerks_Sources_SourceID",
                table: "RacialPerks",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RammingSizeModifiers_Sources_SourceID",
                table: "RammingSizeModifiers",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RangeAndTargetDCs_Sources_SourceID",
                table: "RangeAndTargetDCs",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RitualComponents_Sources_SourceID",
                table: "RitualComponents",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rituals_Sources_SourceID",
                table: "Rituals",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Runes_Sources_SourceID",
                table: "Runes",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Sources_SourceID",
                table: "Services",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillPackages_Sources_SourceID",
                table: "SkillPackages",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Sources_SourceID",
                table: "Skills",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Sources_SourceID",
                table: "Spells",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Sources_SourceID",
                table: "Statistics",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToolKits_Sources_SourceID",
                table: "ToolKits",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrapDiagramComponents_Sources_SourceID",
                table: "TrapDiagramComponents",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrapDiagrams_Sources_SourceID",
                table: "TrapDiagrams",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Traps_Sources_SourceID",
                table: "Traps",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponEffects_Sources_SourceID",
                table: "WeaponEffects",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Sources_SourceID",
                table: "Weapons",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WitcherDecoctions_Sources_SourceID",
                table: "WitcherDecoctions",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WitcherPotions_Sources_SourceID",
                table: "WitcherPotions",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WitcherSigns_Sources_SourceID",
                table: "WitcherSigns",
                column: "SourceID",
                principalTable: "Sources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlchemicalItems_Sources_SourceID",
                table: "AlchemicalItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AlchemicalSubstances_Sources_SourceID",
                table: "AlchemicalSubstances");

            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionEffects_Sources_SourceID",
                table: "AmmunitionEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_Ammunitions_Sources_SourceID",
                table: "Ammunitions");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorCovers_Sources_SourceID",
                table: "ArmorCovers");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorEffects_Sources_SourceID",
                table: "ArmorEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorEnhancements_Sources_SourceID",
                table: "ArmorEnhancements");

            migrationBuilder.DropForeignKey(
                name: "FK_Armors_Sources_SourceID",
                table: "Armors");

            migrationBuilder.DropForeignKey(
                name: "FK_AttackModifiers_Sources_SourceID",
                table: "AttackModifiers");

            migrationBuilder.DropForeignKey(
                name: "FK_BladeOils_Sources_SourceID",
                table: "BladeOils");

            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_Sources_SourceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaes_Sources_SourceID",
                table: "BombFormulaes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bombs_Sources_SourceID",
                table: "Bombs");

            migrationBuilder.DropForeignKey(
                name: "FK_CommonCovers_Sources_SourceID",
                table: "CommonCovers");

            migrationBuilder.DropForeignKey(
                name: "FK_CraftingComponents_Sources_SourceID",
                table: "CraftingComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_CraftingDiagramComponents_Sources_SourceID",
                table: "CraftingDiagramComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_CraftingDiagrams_Sources_SourceID",
                table: "CraftingDiagrams");

            migrationBuilder.DropForeignKey(
                name: "FK_CriticalLevels_Sources_SourceID",
                table: "CriticalLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_CriticalTables_Sources_SourceID",
                table: "CriticalTables");

            migrationBuilder.DropForeignKey(
                name: "FK_DamageLocations_Sources_SourceID",
                table: "DamageLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_DefiningSkillLinks_Sources_SourceID",
                table: "DefiningSkillLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_DefiningSkills_Sources_SourceID",
                table: "DefiningSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_DefiningSkillTables_Sources_SourceID",
                table: "DefiningSkillTables");

            migrationBuilder.DropForeignKey(
                name: "FK_DerivedStatistic_Sources_SourceID",
                table: "DerivedStatistic");

            migrationBuilder.DropForeignKey(
                name: "FK_Effects_Sources_SourceID",
                table: "Effects");

            migrationBuilder.DropForeignKey(
                name: "FK_FormulaeComponents_Sources_SourceID",
                table: "FormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Formulaes_Sources_SourceID",
                table: "Formulaes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fumbles_Sources_SourceID",
                table: "Fumbles");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralGears_Sources_SourceID",
                table: "GeneralGears");

            migrationBuilder.DropForeignKey(
                name: "FK_Glyphs_Sources_SourceID",
                table: "Glyphs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hexs_Sources_SourceID",
                table: "Hexs");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Sources_SourceID",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Invocations_Sources_SourceID",
                table: "Invocations");

            migrationBuilder.DropForeignKey(
                name: "FK_LightLevelModifiers_Sources_SourceID",
                table: "LightLevelModifiers");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterAbilities_Sources_SourceID",
                table: "MonsterAbilities");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterDerivedStatistics_Sources_SourceID",
                table: "MonsterDerivedStatistics");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterInformations_Sources_SourceID",
                table: "MonsterInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterLoots_Sources_SourceID",
                table: "MonsterLoots");

            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Sources_SourceID",
                table: "Monsters");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterSkills_Sources_SourceID",
                table: "MonsterSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterStatistics_Sources_SourceID",
                table: "MonsterStatistics");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterVulnerabilities_Sources_SourceID",
                table: "MonsterVulnerabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_MonsterWeapons_Sources_SourceID",
                table: "MonsterWeapons");

            migrationBuilder.DropForeignKey(
                name: "FK_Mount_Vehicles_Sources_SourceID",
                table: "Mount_Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_MountOutfits_Sources_SourceID",
                table: "MountOutfits");

            migrationBuilder.DropForeignKey(
                name: "FK_Mutagens_Sources_SourceID",
                table: "Mutagens");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacesOfPowers_Sources_SourceID",
                table: "PlacesOfPowers");

            migrationBuilder.DropForeignKey(
                name: "FK_Professions_Sources_SourceID",
                table: "Professions");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Sources_SourceID",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_RacialPerks_Sources_SourceID",
                table: "RacialPerks");

            migrationBuilder.DropForeignKey(
                name: "FK_RammingSizeModifiers_Sources_SourceID",
                table: "RammingSizeModifiers");

            migrationBuilder.DropForeignKey(
                name: "FK_RangeAndTargetDCs_Sources_SourceID",
                table: "RangeAndTargetDCs");

            migrationBuilder.DropForeignKey(
                name: "FK_RitualComponents_Sources_SourceID",
                table: "RitualComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rituals_Sources_SourceID",
                table: "Rituals");

            migrationBuilder.DropForeignKey(
                name: "FK_Runes_Sources_SourceID",
                table: "Runes");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Sources_SourceID",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillPackages_Sources_SourceID",
                table: "SkillPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Sources_SourceID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Sources_SourceID",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Sources_SourceID",
                table: "Statistics");

            migrationBuilder.DropForeignKey(
                name: "FK_ToolKits_Sources_SourceID",
                table: "ToolKits");

            migrationBuilder.DropForeignKey(
                name: "FK_TrapDiagramComponents_Sources_SourceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_TrapDiagrams_Sources_SourceID",
                table: "TrapDiagrams");

            migrationBuilder.DropForeignKey(
                name: "FK_Traps_Sources_SourceID",
                table: "Traps");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponEffects_Sources_SourceID",
                table: "WeaponEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Sources_SourceID",
                table: "Weapons");

            migrationBuilder.DropForeignKey(
                name: "FK_WitcherDecoctions_Sources_SourceID",
                table: "WitcherDecoctions");

            migrationBuilder.DropForeignKey(
                name: "FK_WitcherPotions_Sources_SourceID",
                table: "WitcherPotions");

            migrationBuilder.DropForeignKey(
                name: "FK_WitcherSigns_Sources_SourceID",
                table: "WitcherSigns");

            migrationBuilder.DropIndex(
                name: "IX_WitcherSigns_SourceID",
                table: "WitcherSigns");

            migrationBuilder.DropIndex(
                name: "IX_WitcherPotions_SourceID",
                table: "WitcherPotions");

            migrationBuilder.DropIndex(
                name: "IX_WitcherDecoctions_SourceID",
                table: "WitcherDecoctions");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_SourceID",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_WeaponEffects_SourceID",
                table: "WeaponEffects");

            migrationBuilder.DropIndex(
                name: "IX_Traps_SourceID",
                table: "Traps");

            migrationBuilder.DropIndex(
                name: "IX_TrapDiagrams_SourceID",
                table: "TrapDiagrams");

            migrationBuilder.DropIndex(
                name: "IX_TrapDiagramComponents_SourceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropIndex(
                name: "IX_ToolKits_SourceID",
                table: "ToolKits");

            migrationBuilder.DropIndex(
                name: "IX_Statistics_SourceID",
                table: "Statistics");

            migrationBuilder.DropIndex(
                name: "IX_Spells_SourceID",
                table: "Spells");

            migrationBuilder.DropIndex(
                name: "IX_Skills_SourceID",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_SkillPackages_SourceID",
                table: "SkillPackages");

            migrationBuilder.DropIndex(
                name: "IX_Services_SourceID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Runes_SourceID",
                table: "Runes");

            migrationBuilder.DropIndex(
                name: "IX_Rituals_SourceID",
                table: "Rituals");

            migrationBuilder.DropIndex(
                name: "IX_RitualComponents_SourceID",
                table: "RitualComponents");

            migrationBuilder.DropIndex(
                name: "IX_RangeAndTargetDCs_SourceID",
                table: "RangeAndTargetDCs");

            migrationBuilder.DropIndex(
                name: "IX_RammingSizeModifiers_SourceID",
                table: "RammingSizeModifiers");

            migrationBuilder.DropIndex(
                name: "IX_RacialPerks_SourceID",
                table: "RacialPerks");

            migrationBuilder.DropIndex(
                name: "IX_Races_SourceID",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Professions_SourceID",
                table: "Professions");

            migrationBuilder.DropIndex(
                name: "IX_PlacesOfPowers_SourceID",
                table: "PlacesOfPowers");

            migrationBuilder.DropIndex(
                name: "IX_Mutagens_SourceID",
                table: "Mutagens");

            migrationBuilder.DropIndex(
                name: "IX_MountOutfits_SourceID",
                table: "MountOutfits");

            migrationBuilder.DropIndex(
                name: "IX_Mount_Vehicles_SourceID",
                table: "Mount_Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_MonsterWeapons_SourceID",
                table: "MonsterWeapons");

            migrationBuilder.DropIndex(
                name: "IX_MonsterVulnerabilities_SourceID",
                table: "MonsterVulnerabilities");

            migrationBuilder.DropIndex(
                name: "IX_MonsterStatistics_SourceID",
                table: "MonsterStatistics");

            migrationBuilder.DropIndex(
                name: "IX_MonsterSkills_SourceID",
                table: "MonsterSkills");

            migrationBuilder.DropIndex(
                name: "IX_Monsters_SourceID",
                table: "Monsters");

            migrationBuilder.DropIndex(
                name: "IX_MonsterLoots_SourceID",
                table: "MonsterLoots");

            migrationBuilder.DropIndex(
                name: "IX_MonsterInformations_SourceID",
                table: "MonsterInformations");

            migrationBuilder.DropIndex(
                name: "IX_MonsterDerivedStatistics_SourceID",
                table: "MonsterDerivedStatistics");

            migrationBuilder.DropIndex(
                name: "IX_MonsterAbilities_SourceID",
                table: "MonsterAbilities");

            migrationBuilder.DropIndex(
                name: "IX_LightLevelModifiers_SourceID",
                table: "LightLevelModifiers");

            migrationBuilder.DropIndex(
                name: "IX_Invocations_SourceID",
                table: "Invocations");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_SourceID",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Hexs_SourceID",
                table: "Hexs");

            migrationBuilder.DropIndex(
                name: "IX_Glyphs_SourceID",
                table: "Glyphs");

            migrationBuilder.DropIndex(
                name: "IX_GeneralGears_SourceID",
                table: "GeneralGears");

            migrationBuilder.DropIndex(
                name: "IX_Fumbles_SourceID",
                table: "Fumbles");

            migrationBuilder.DropIndex(
                name: "IX_Formulaes_SourceID",
                table: "Formulaes");

            migrationBuilder.DropIndex(
                name: "IX_FormulaeComponents_SourceID",
                table: "FormulaeComponents");

            migrationBuilder.DropIndex(
                name: "IX_Effects_SourceID",
                table: "Effects");

            migrationBuilder.DropIndex(
                name: "IX_DerivedStatistic_SourceID",
                table: "DerivedStatistic");

            migrationBuilder.DropIndex(
                name: "IX_DefiningSkillTables_SourceID",
                table: "DefiningSkillTables");

            migrationBuilder.DropIndex(
                name: "IX_DefiningSkills_SourceID",
                table: "DefiningSkills");

            migrationBuilder.DropIndex(
                name: "IX_DefiningSkillLinks_SourceID",
                table: "DefiningSkillLinks");

            migrationBuilder.DropIndex(
                name: "IX_DamageLocations_SourceID",
                table: "DamageLocations");

            migrationBuilder.DropIndex(
                name: "IX_CriticalTables_SourceID",
                table: "CriticalTables");

            migrationBuilder.DropIndex(
                name: "IX_CriticalLevels_SourceID",
                table: "CriticalLevels");

            migrationBuilder.DropIndex(
                name: "IX_CraftingDiagrams_SourceID",
                table: "CraftingDiagrams");

            migrationBuilder.DropIndex(
                name: "IX_CraftingDiagramComponents_SourceID",
                table: "CraftingDiagramComponents");

            migrationBuilder.DropIndex(
                name: "IX_CraftingComponents_SourceID",
                table: "CraftingComponents");

            migrationBuilder.DropIndex(
                name: "IX_CommonCovers_SourceID",
                table: "CommonCovers");

            migrationBuilder.DropIndex(
                name: "IX_Bombs_SourceID",
                table: "Bombs");

            migrationBuilder.DropIndex(
                name: "IX_BombFormulaes_SourceID",
                table: "BombFormulaes");

            migrationBuilder.DropIndex(
                name: "IX_BombFormulaeComponents_SourceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropIndex(
                name: "IX_BladeOils_SourceID",
                table: "BladeOils");

            migrationBuilder.DropIndex(
                name: "IX_AttackModifiers_SourceID",
                table: "AttackModifiers");

            migrationBuilder.DropIndex(
                name: "IX_Armors_SourceID",
                table: "Armors");

            migrationBuilder.DropIndex(
                name: "IX_ArmorEnhancements_SourceID",
                table: "ArmorEnhancements");

            migrationBuilder.DropIndex(
                name: "IX_ArmorEffects_SourceID",
                table: "ArmorEffects");

            migrationBuilder.DropIndex(
                name: "IX_ArmorCovers_SourceID",
                table: "ArmorCovers");

            migrationBuilder.DropIndex(
                name: "IX_Ammunitions_SourceID",
                table: "Ammunitions");

            migrationBuilder.DropIndex(
                name: "IX_AmmunitionEffects_SourceID",
                table: "AmmunitionEffects");

            migrationBuilder.DropIndex(
                name: "IX_AlchemicalSubstances_SourceID",
                table: "AlchemicalSubstances");

            migrationBuilder.DropIndex(
                name: "IX_AlchemicalItems_SourceID",
                table: "AlchemicalItems");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "WitcherSigns");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "WitcherSigns");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "WitcherPotions");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "WitcherPotions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "WitcherDecoctions");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "WitcherDecoctions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "WeaponEffects");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "WeaponEffects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Traps");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Traps");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "TrapDiagrams");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "TrapDiagrams");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ToolKits");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "ToolKits");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "SkillPackages");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "SkillPackages");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Runes");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Runes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Rituals");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Rituals");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RitualComponents");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "RitualComponents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RangeAndTargetDCs");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "RangeAndTargetDCs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RammingSizeModifiers");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "RammingSizeModifiers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "RacialPerks");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "RacialPerks");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "PlacesOfPowers");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "PlacesOfPowers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Mutagens");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Mutagens");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MountOutfits");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MountOutfits");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Mount_Vehicles");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Mount_Vehicles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterWeapons");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterWeapons");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterVulnerabilities");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterVulnerabilities");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterStatistics");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterStatistics");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterSkills");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterSkills");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterLoots");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterLoots");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterInformations");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterInformations");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterDerivedStatistics");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterDerivedStatistics");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "MonsterAbilities");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "MonsterAbilities");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "LightLevelModifiers");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "LightLevelModifiers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Invocations");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Invocations");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Hexs");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Hexs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Glyphs");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Glyphs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "GeneralGears");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "GeneralGears");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Fumbles");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Fumbles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Formulaes");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Formulaes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DerivedStatistic");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "DerivedStatistic");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DefiningSkillTables");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "DefiningSkillTables");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DefiningSkills");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "DefiningSkills");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DefiningSkillLinks");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "DefiningSkillLinks");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "DamageLocations");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "DamageLocations");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CriticalTables");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "CriticalTables");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CriticalLevels");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "CriticalLevels");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CraftingDiagrams");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "CraftingDiagrams");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CraftingDiagramComponents");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "CraftingDiagramComponents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CraftingComponents");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "CraftingComponents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CommonCovers");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "CommonCovers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Bombs");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Bombs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "BombFormulaes");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "BombFormulaes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "BladeOils");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "BladeOils");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AttackModifiers");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "AttackModifiers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "ArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ArmorEffects");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "ArmorEffects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ArmorCovers");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "ArmorCovers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Ammunitions");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "Ammunitions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AmmunitionEffects");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "AmmunitionEffects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AlchemicalSubstances");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "AlchemicalSubstances");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "AlchemicalItems");

            migrationBuilder.DropColumn(
                name: "SourceID",
                table: "AlchemicalItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Campaigns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Campaigns",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CampaignNotes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CampaignNotes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "EffectPackages",
                columns: table => new
                {
                    EffectPackageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EffectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectPackages", x => x.EffectPackageID);
                    table.ForeignKey(
                        name: "FK_EffectPackages_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EffectPackages_EffectID",
                table: "EffectPackages",
                column: "EffectID");
        }
    }
}
