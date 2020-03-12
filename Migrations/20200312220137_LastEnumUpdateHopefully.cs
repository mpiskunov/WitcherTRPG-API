using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class LastEnumUpdateHopefully : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "MountOutfits");

            migrationBuilder.RenameColumn("AvailabilityEnum", "MountOutfits", "Availability");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("Availability", "MountOutfits", "AvailabilityEnum");
            migrationBuilder.AddColumn<int>(
                name: "Availability",
                table: "MountOutfits",
                nullable: false,
                defaultValue: 0);
        }
    }
}
