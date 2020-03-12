using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class ChangedIntToEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpellTypeClassification",
                table: "WitcherSigns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WitcherSignClassification",
                table: "WitcherSigns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "Weapons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponClassification",
                table: "Weapons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "ToolKits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatisticCategory",
                table: "Statistics",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellDifficultyClassification",
                table: "Spells",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellTypeClassification",
                table: "Spells",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillCategory",
                table: "Skills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellDifficultyClassification",
                table: "Rituals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaceType",
                table: "Races",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessionCategory",
                table: "Professions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MutagenType",
                table: "Mutagens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MountOutfitClassification",
                table: "MountOutfits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "Invocations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellTypeClassification",
                table: "Invocations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Availability",
                table: "Ingredients",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GeneralGearClassification",
                table: "GeneralGears",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "Formulaes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlchemyCategory",
                table: "FormulaeComponents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefiningSkillTableType",
                table: "DefiningSkillTables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CriticalLevelCategory",
                table: "CriticalLevels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramCategory",
                table: "CraftingDiagrams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevel",
                table: "CraftingDiagrams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CraftingComponentType",
                table: "CraftingComponents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "Armors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeightClassification",
                table: "Armors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "ArmorEnhancements",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArmorClassification",
                table: "ArmorCovers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "Ammunitions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConcealmentEnum",
                table: "Ammunitions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "AlchemicalItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpellTypeClassification",
                table: "WitcherSigns");

            migrationBuilder.DropColumn(
                name: "WitcherSignClassification",
                table: "WitcherSigns");

            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "WeaponClassification",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "ToolKits");

            migrationBuilder.DropColumn(
                name: "StatisticCategory",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "SpellDifficultyClassification",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SpellTypeClassification",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SkillCategory",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "SpellDifficultyClassification",
                table: "Rituals");

            migrationBuilder.DropColumn(
                name: "RaceType",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ProfessionCategory",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "MutagenType",
                table: "Mutagens");

            migrationBuilder.DropColumn(
                name: "MountOutfitClassification",
                table: "MountOutfits");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "Invocations");

            migrationBuilder.DropColumn(
                name: "SpellTypeClassification",
                table: "Invocations");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "GeneralGearClassification",
                table: "GeneralGears");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "Formulaes");

            migrationBuilder.DropColumn(
                name: "AlchemyCategory",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "DefiningSkillTableType",
                table: "DefiningSkillTables");

            migrationBuilder.DropColumn(
                name: "CriticalLevelCategory",
                table: "CriticalLevels");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramCategory",
                table: "CraftingDiagrams");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "CraftingDiagrams");

            migrationBuilder.DropColumn(
                name: "CraftingComponentType",
                table: "CraftingComponents");

            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "WeightClassification",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "ArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "ArmorClassification",
                table: "ArmorCovers");

            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "Ammunitions");

            migrationBuilder.DropColumn(
                name: "ConcealmentEnum",
                table: "Ammunitions");

            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "AlchemicalItems");
        }
    }
}
