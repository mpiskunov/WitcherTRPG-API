using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedWeaponEffectValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "WeaponEffect",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "ArmorEffect",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "WeaponEffect");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ArmorEffect");
        }
    }
}
