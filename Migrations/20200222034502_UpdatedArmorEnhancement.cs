using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class UpdatedArmorEnhancement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ArmorEnhancements");

            migrationBuilder.AddColumn<string>(
                name: "Effect",
                table: "ArmorEnhancements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Effect",
                table: "ArmorEnhancements");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ArmorEnhancements",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
