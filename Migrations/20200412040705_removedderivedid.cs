using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class removedderivedid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DerivedStatisticID",
                table: "DerivedStatistic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DerivedStatisticID",
                table: "DerivedStatistic",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
