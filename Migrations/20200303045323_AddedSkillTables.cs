using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedSkillTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefiningSkillTables",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefiningSkillID = table.Column<int>(nullable: false),
                    FirstColumn = table.Column<string>(nullable: true),
                    FirstColumnValue = table.Column<string>(nullable: true),
                    SecondColumn = table.Column<string>(nullable: true),
                    SecondColumnValue = table.Column<string>(nullable: true),
                    DefiningSkillFilter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefiningSkillTables", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefiningSkillTables_DefiningSkills_DefiningSkillID",
                        column: x => x.DefiningSkillID,
                        principalTable: "DefiningSkills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkillTables_DefiningSkillID",
                table: "DefiningSkillTables",
                column: "DefiningSkillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefiningSkillTables");
        }
    }
}
