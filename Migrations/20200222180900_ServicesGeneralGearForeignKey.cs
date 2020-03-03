using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class ServicesGeneralGearForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneralGearID",
                table: "Services",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_GeneralGearID",
                table: "Services",
                column: "GeneralGearID");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_GeneralGears_GeneralGearID",
                table: "Services",
                column: "GeneralGearID",
                principalTable: "GeneralGears",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_GeneralGears_GeneralGearID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_GeneralGearID",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "GeneralGearID",
                table: "Services");
        }
    }
}
