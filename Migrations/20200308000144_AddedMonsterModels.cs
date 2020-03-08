using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedMonsterModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBladeOils_BladeOils_BladeOilID",
                table: "CharacterBladeOils");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBladeOils_CharacterSheets_CharacterSheetID",
                table: "CharacterBladeOils");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterBladeOils",
                table: "CharacterBladeOils");

            migrationBuilder.RenameTable(
                name: "CharacterBladeOils",
                newName: "CharacterBladeOil");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBladeOils_BladeOilID",
                table: "CharacterBladeOil",
                newName: "IX_CharacterBladeOil_BladeOilID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterBladeOil",
                table: "CharacterBladeOil",
                columns: new[] { "CharacterSheetID", "BladeOilID" });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Threat = table.Column<string>(nullable: true),
                    Bounty = table.Column<decimal>(nullable: false),
                    ArmorValue = table.Column<int>(nullable: false),
                    Height = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Environment = table.Column<string>(nullable: true),
                    Intelligence = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    MonsterType = table.Column<int>(nullable: false),
                    INT = table.Column<int>(nullable: false),
                    REF = table.Column<int>(nullable: false),
                    DEX = table.Column<int>(nullable: false),
                    BODY = table.Column<int>(nullable: false),
                    SPD = table.Column<int>(nullable: false),
                    EMP = table.Column<int>(nullable: false),
                    CRA = table.Column<int>(nullable: false),
                    WILL = table.Column<int>(nullable: false),
                    LUCK = table.Column<int>(nullable: false),
                    STUN = table.Column<int>(nullable: false),
                    RUN = table.Column<int>(nullable: false),
                    LEAP = table.Column<int>(nullable: false),
                    STA = table.Column<int>(nullable: false),
                    ENC = table.Column<int>(nullable: false),
                    REC = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    Vigor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonsterAbilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAbilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterAbilities_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterInformations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterInformations_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterLoots",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLoots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterLoots_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSkills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSkills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterSkills_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterVulnerabilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterVulnerabilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterVulnerabilities_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterWeapons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonsterID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    RateOfFire = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterWeapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterWeapons_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAbilities_MonsterID",
                table: "MonsterAbilities",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterInformations_MonsterID",
                table: "MonsterInformations",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoots_MonsterID",
                table: "MonsterLoots",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkills_MonsterID",
                table: "MonsterSkills",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkills_SkillID",
                table: "MonsterSkills",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterVulnerabilities_MonsterID",
                table: "MonsterVulnerabilities",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeapons_MonsterID",
                table: "MonsterWeapons",
                column: "MonsterID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBladeOil_BladeOils_BladeOilID",
                table: "CharacterBladeOil",
                column: "BladeOilID",
                principalTable: "BladeOils",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBladeOil_CharacterSheets_CharacterSheetID",
                table: "CharacterBladeOil",
                column: "CharacterSheetID",
                principalTable: "CharacterSheets",
                principalColumn: "CharacterSheetID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBladeOil_BladeOils_BladeOilID",
                table: "CharacterBladeOil");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBladeOil_CharacterSheets_CharacterSheetID",
                table: "CharacterBladeOil");

            migrationBuilder.DropTable(
                name: "MonsterAbilities");

            migrationBuilder.DropTable(
                name: "MonsterInformations");

            migrationBuilder.DropTable(
                name: "MonsterLoots");

            migrationBuilder.DropTable(
                name: "MonsterSkills");

            migrationBuilder.DropTable(
                name: "MonsterVulnerabilities");

            migrationBuilder.DropTable(
                name: "MonsterWeapons");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterBladeOil",
                table: "CharacterBladeOil");

            migrationBuilder.RenameTable(
                name: "CharacterBladeOil",
                newName: "CharacterBladeOils");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBladeOil_BladeOilID",
                table: "CharacterBladeOils",
                newName: "IX_CharacterBladeOils_BladeOilID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterBladeOils",
                table: "CharacterBladeOils",
                columns: new[] { "CharacterSheetID", "BladeOilID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBladeOils_BladeOils_BladeOilID",
                table: "CharacterBladeOils",
                column: "BladeOilID",
                principalTable: "BladeOils",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBladeOils_CharacterSheets_CharacterSheetID",
                table: "CharacterBladeOils",
                column: "CharacterSheetID",
                principalTable: "CharacterSheets",
                principalColumn: "CharacterSheetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
