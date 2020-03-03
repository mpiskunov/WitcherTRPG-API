using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class updatedcolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaminaType",
                table: "WitcherSigns");

            migrationBuilder.AddColumn<string>(
                name: "StaminaCost",
                table: "WitcherSigns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaminaCost",
                table: "WitcherSigns");

            migrationBuilder.AddColumn<string>(
                name: "StaminaType",
                table: "WitcherSigns",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
