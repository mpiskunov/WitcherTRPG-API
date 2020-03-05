using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class addedmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BladeOils",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Effects = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BladeOils", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mutagens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MutagenSource = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    AlchemyDC = table.Column<int>(nullable: false),
                    MinorMutation = table.Column<string>(nullable: true),
                    TypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutagens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WitcherDecoctions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WitcherDecoctions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WitcherPotions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Effects = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Toxicity = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WitcherPotions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterBladeOils",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    BladeOilID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterBladeOils", x => new { x.CharacterSheetID, x.BladeOilID });
                    table.ForeignKey(
                        name: "FK_CharacterBladeOils_BladeOils_BladeOilID",
                        column: x => x.BladeOilID,
                        principalTable: "BladeOils",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterBladeOils_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMutagens",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    MutagenID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMutagens", x => new { x.CharacterSheetID, x.MutagenID });
                    table.ForeignKey(
                        name: "FK_CharacterMutagens_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMutagens_Mutagens_MutagenID",
                        column: x => x.MutagenID,
                        principalTable: "Mutagens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWitcherDecoctions",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WitcherDecoctionID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWitcherDecoctions", x => new { x.CharacterSheetID, x.WitcherDecoctionID });
                    table.ForeignKey(
                        name: "FK_CharacterWitcherDecoctions_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWitcherDecoctions_WitcherDecoctions_WitcherDecoctionID",
                        column: x => x.WitcherDecoctionID,
                        principalTable: "WitcherDecoctions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWitcherPotions",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WitcherPotionID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWitcherPotions", x => new { x.CharacterSheetID, x.WitcherPotionID });
                    table.ForeignKey(
                        name: "FK_CharacterWitcherPotions_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWitcherPotions_WitcherPotions_WitcherPotionID",
                        column: x => x.WitcherPotionID,
                        principalTable: "WitcherPotions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterBladeOils_BladeOilID",
                table: "CharacterBladeOils",
                column: "BladeOilID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMutagens_MutagenID",
                table: "CharacterMutagens",
                column: "MutagenID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWitcherDecoctions_WitcherDecoctionID",
                table: "CharacterWitcherDecoctions",
                column: "WitcherDecoctionID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWitcherPotions_WitcherPotionID",
                table: "CharacterWitcherPotions",
                column: "WitcherPotionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterBladeOils");

            migrationBuilder.DropTable(
                name: "CharacterMutagens");

            migrationBuilder.DropTable(
                name: "CharacterWitcherDecoctions");

            migrationBuilder.DropTable(
                name: "CharacterWitcherPotions");

            migrationBuilder.DropTable(
                name: "BladeOils");

            migrationBuilder.DropTable(
                name: "Mutagens");

            migrationBuilder.DropTable(
                name: "WitcherDecoctions");

            migrationBuilder.DropTable(
                name: "WitcherPotions");
        }
    }
}
