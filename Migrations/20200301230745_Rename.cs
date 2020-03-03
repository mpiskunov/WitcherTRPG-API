using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionDiagramComponents_Substances_SubstanceID",
                table: "AmmunitionDiagramComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_Substances_SubstanceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSubstances_Substances_SubstanceID",
                table: "CharacterSubstances");

            migrationBuilder.DropForeignKey(
                name: "FK_TrapDiagramComponents_Substances_SubstanceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropTable(
                name: "Substances");

            migrationBuilder.CreateTable(
                name: "AlchemicalSubstances",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlchemicalSubstances", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Rarity = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    ForageDC = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    AlchemicalSubstanceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingredients_AlchemicalSubstances_AlchemicalSubstanceID",
                        column: x => x.AlchemicalSubstanceID,
                        principalTable: "AlchemicalSubstances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_AlchemicalSubstanceID",
                table: "Ingredients",
                column: "AlchemicalSubstanceID");

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionDiagramComponents_Ingredients_SubstanceID",
                table: "AmmunitionDiagramComponents",
                column: "SubstanceID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BombFormulaeComponents_Ingredients_SubstanceID",
                table: "BombFormulaeComponents",
                column: "SubstanceID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSubstances_Ingredients_SubstanceID",
                table: "CharacterSubstances",
                column: "SubstanceID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrapDiagramComponents_Ingredients_SubstanceID",
                table: "TrapDiagramComponents",
                column: "SubstanceID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionDiagramComponents_Ingredients_SubstanceID",
                table: "AmmunitionDiagramComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_Ingredients_SubstanceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSubstances_Ingredients_SubstanceID",
                table: "CharacterSubstances");

            migrationBuilder.DropForeignKey(
                name: "FK_TrapDiagramComponents_Ingredients_SubstanceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "AlchemicalSubstances");

            migrationBuilder.CreateTable(
                name: "Substances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ForageDC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substances", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionDiagramComponents_Substances_SubstanceID",
                table: "AmmunitionDiagramComponents",
                column: "SubstanceID",
                principalTable: "Substances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BombFormulaeComponents_Substances_SubstanceID",
                table: "BombFormulaeComponents",
                column: "SubstanceID",
                principalTable: "Substances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSubstances_Substances_SubstanceID",
                table: "CharacterSubstances",
                column: "SubstanceID",
                principalTable: "Substances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrapDiagramComponents_Substances_SubstanceID",
                table: "TrapDiagramComponents",
                column: "SubstanceID",
                principalTable: "Substances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
