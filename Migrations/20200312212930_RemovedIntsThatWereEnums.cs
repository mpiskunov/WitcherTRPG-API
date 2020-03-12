using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class RemovedIntsThatWereEnums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ArmorCovers",
                table: "ArmorCovers");

            migrationBuilder.DropColumn(
                name: "SignClassificationID",
                table: "WitcherSigns");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "WitcherSigns");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Concealment",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "WeaponCategoryID",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "ToolKits");

            migrationBuilder.DropColumn(
                name: "StatisticTypeID",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "SkillLevelID",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SpellCategoryID",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "SkillTypeID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DifficultyTypeID",
                table: "Rituals");

            migrationBuilder.DropColumn(
                name: "RaceCategoryID",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ProfessionCategoryID",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Mutagens");

            migrationBuilder.DropColumn(
                name: "ClassificationTypeID",
                table: "MountOutfits");

            migrationBuilder.DropColumn(
                name: "SkillLevelID",
                table: "Invocations");

            migrationBuilder.DropColumn(
                name: "SpellCategoryID",
                table: "Invocations");

            migrationBuilder.DropColumn(
                name: "Rarity",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "GeneralGears");

            migrationBuilder.DropColumn(
                name: "SkillLevelID",
                table: "Formulaes");

            migrationBuilder.DropColumn(
                name: "SubstanceCategoryID",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "TableType",
                table: "DefiningSkillTables");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "CriticalLevels");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "CraftingDiagrams");

            migrationBuilder.DropColumn(
                name: "SkillLevelID",
                table: "CraftingDiagrams");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "CraftingComponents");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "WeightCategoryID",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "ArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "ArmorClassificationID",
                table: "ArmorCovers");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Ammunitions");

            migrationBuilder.DropColumn(
                name: "Concealment",
                table: "Ammunitions");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "AlchemicalItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArmorCovers",
                table: "ArmorCovers",
                columns: new[] { "ArmorID", "ArmorClassification" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ArmorCovers",
                table: "ArmorCovers");

            migrationBuilder.AddColumn<int>(
                name: "SignClassificationID",
                table: "WitcherSigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "WitcherSigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Concealment",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponCategoryID",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "ToolKits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatisticTypeID",
                table: "Statistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevelID",
                table: "Spells",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellCategoryID",
                table: "Spells",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillTypeID",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DifficultyTypeID",
                table: "Rituals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaceCategoryID",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProfessionCategoryID",
                table: "Professions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Mutagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassificationTypeID",
                table: "MountOutfits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevelID",
                table: "Invocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpellCategoryID",
                table: "Invocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rarity",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "GeneralGears",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevelID",
                table: "Formulaes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubstanceCategoryID",
                table: "FormulaeComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableType",
                table: "DefiningSkillTables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "CriticalLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "CraftingDiagrams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevelID",
                table: "CraftingDiagrams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "CraftingComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Armors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeightCategoryID",
                table: "Armors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "ArmorEnhancements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArmorClassificationID",
                table: "ArmorCovers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Ammunitions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Concealment",
                table: "Ammunitions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "AlchemicalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArmorCovers",
                table: "ArmorCovers",
                columns: new[] { "ArmorID", "ArmorClassificationID" });
        }
    }
}
