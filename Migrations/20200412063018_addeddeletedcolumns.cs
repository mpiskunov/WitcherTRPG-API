using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class addeddeletedcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterWitcherSigns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterWitcherPotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterWitcherDecoctions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterWeapons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterWeaponEffects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterTraps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterToolKits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterSubstances",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterStatistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterSpells",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterSkills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterRunes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterRituals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterNotes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterMutagens",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterMountOutfits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterMount_Vehicles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterLifeEvents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterInvocations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterHexs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterGlyphs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterGeneralGears",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterFormulaes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterEffects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterEarlyLifeNotes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterDerivedStatistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterDefiningSkills",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterCampaignNotes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterBombs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterBladeOil",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterArmors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterArmorEnhancements",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterArmorEffects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterAmmunitions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CharacterAlchemicalItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "CampaignNotes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterWitcherSigns");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterWitcherPotions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterWitcherDecoctions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterWeapons");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterTraps");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterToolKits");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterSubstances");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterStatistics");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterSpells");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterSkills");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterServices");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterRunes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterRituals");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterNotes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterMutagens");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterMountOutfits");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterMount_Vehicles");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterLifeEvents");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterInvocations");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterHexs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterGlyphs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterGeneralGears");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterFormulaes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterEffects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterEarlyLifeNotes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterDerivedStatistics");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterDefiningSkills");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterCampaignNotes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterBombs");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterBladeOil");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterArmors");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterAmmunitions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CharacterAlchemicalItems");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "CampaignNotes");
        }
    }
}
