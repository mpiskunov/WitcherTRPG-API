using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class UpdatedSkillTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DifficultyToLearn",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "PointsPerLevel",
                table: "Skills",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointsPerLevel",
                table: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "DifficultyToLearn",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
