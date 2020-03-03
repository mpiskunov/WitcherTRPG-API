using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class tablenamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterPriestInvocations");

            migrationBuilder.DropTable(
                name: "PriestInvocations");

            migrationBuilder.CreateTable(
                name: "Invocations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    Deity = table.Column<string>(nullable: true),
                    SkillLevelID = table.Column<int>(nullable: false),
                    SpellCategoryID = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invocations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInvocations",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    InvocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInvocations", x => new { x.CharacterSheetID, x.InvocationID });
                    table.ForeignKey(
                        name: "FK_CharacterInvocations_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInvocations_Invocations_InvocationID",
                        column: x => x.InvocationID,
                        principalTable: "Invocations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInvocations_InvocationID",
                table: "CharacterInvocations",
                column: "InvocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterInvocations");

            migrationBuilder.DropTable(
                name: "Invocations");

            migrationBuilder.CreateTable(
                name: "PriestInvocations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Defense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillLevelID = table.Column<int>(type: "int", nullable: false),
                    SpellCategoryID = table.Column<int>(type: "int", nullable: false),
                    StaminaCost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriestInvocations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterPriestInvocations",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(type: "int", nullable: false),
                    PriestInvocationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterPriestInvocations", x => new { x.CharacterSheetID, x.PriestInvocationID });
                    table.ForeignKey(
                        name: "FK_CharacterPriestInvocations_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterPriestInvocations_PriestInvocations_PriestInvocationID",
                        column: x => x.PriestInvocationID,
                        principalTable: "PriestInvocations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPriestInvocations_PriestInvocationID",
                table: "CharacterPriestInvocations",
                column: "PriestInvocationID");
        }
    }
}
