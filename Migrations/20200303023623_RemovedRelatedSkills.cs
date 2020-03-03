using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class RemovedRelatedSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefiningSkills_Statistics_FollowingSkillID",
                table: "DefiningSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_DefiningSkills_Statistics_PreviousSkillID",
                table: "DefiningSkills");

            migrationBuilder.DropIndex(
                name: "IX_DefiningSkills_FollowingSkillID",
                table: "DefiningSkills");

            migrationBuilder.DropIndex(
                name: "IX_DefiningSkills_PreviousSkillID",
                table: "DefiningSkills");

            migrationBuilder.DropColumn(
                name: "FollowingSkillID",
                table: "DefiningSkills");

            migrationBuilder.DropColumn(
                name: "PreviousSkillID",
                table: "DefiningSkills");

            migrationBuilder.CreateTable(
                name: "DefiningSkillLinks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefiningSkillID = table.Column<int>(nullable: false),
                    NextDefiningSkillID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefiningSkillLinks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefiningSkillLinks");

            migrationBuilder.AddColumn<int>(
                name: "FollowingSkillID",
                table: "DefiningSkills",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreviousSkillID",
                table: "DefiningSkills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_FollowingSkillID",
                table: "DefiningSkills",
                column: "FollowingSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_PreviousSkillID",
                table: "DefiningSkills",
                column: "PreviousSkillID");

            migrationBuilder.AddForeignKey(
                name: "FK_DefiningSkills_Statistics_FollowingSkillID",
                table: "DefiningSkills",
                column: "FollowingSkillID",
                principalTable: "Statistics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefiningSkills_Statistics_PreviousSkillID",
                table: "DefiningSkills",
                column: "PreviousSkillID",
                principalTable: "Statistics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
