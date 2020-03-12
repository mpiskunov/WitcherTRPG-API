using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class renamedenums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("AvailabilityEnum", "Weapons", "Availability");
            migrationBuilder.RenameColumn("ConcealmentEnum", "Weapons", "Concealment");
            migrationBuilder.RenameColumn("AvailabilityEnum", "ToolKits", "Availability");
            migrationBuilder.RenameColumn("AvailabilityEnum", "Armors", "Availability");
            migrationBuilder.RenameColumn("AvailabilityEnum", "ArmorEnhancements", "Availability");
            migrationBuilder.RenameColumn("AvailabilityEnum", "Ammunitions", "Availability");
            migrationBuilder.RenameColumn("ConcealmentEnum", "Ammunitions", "Concealment");
            migrationBuilder.RenameColumn("AvailabilityEnum", "AlchemicalItems", "Availability");
            migrationBuilder.AddColumn<int>(
                name: "AvailabilityEnum",
                table: "MountOutfits",
                nullable: false,
                defaultValue: 0);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.RenameColumn("Availability", "Weapons", "AvailabilityEnum");
            migrationBuilder.RenameColumn("Concealment", "Weapons", "ConcealmentEnum");
            migrationBuilder.RenameColumn("Availability", "ToolKits", "AvailabilityEnum");
            migrationBuilder.RenameColumn("Availability", "Armors", "AvailabilityEnum");
            migrationBuilder.RenameColumn("Availability", "ArmorEnhancements", "AvailabilityEnum");
            migrationBuilder.RenameColumn("Availability", "Ammunitions", "AvailabilityEnum");
            migrationBuilder.RenameColumn("Concealment", "Ammunitions", "ConcealmentEnum");
            migrationBuilder.RenameColumn("Availability", "AlchemicalItems", "AvailabilityEnum");
            migrationBuilder.DropColumn(
                name: "AvailabilityEnum",
                table: "MountOutfits");

        }
    }
}
