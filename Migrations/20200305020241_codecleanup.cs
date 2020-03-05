using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class codecleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmmunitionDiagramComponents");

            migrationBuilder.DropTable(
                name: "AmmunitionDiagrams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmmunitionDiagrams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmunitionID = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CraftDC = table.Column<int>(type: "int", nullable: false),
                    Investment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmunitionDiagrams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AmmunitionDiagrams_Ammunitions_AmmunitionID",
                        column: x => x.AmmunitionID,
                        principalTable: "Ammunitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmmunitionDiagramComponents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmunitionDiagramID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CraftingDiagramComponentCraftingComponentID = table.Column<int>(type: "int", nullable: true),
                    CraftingDiagramComponentCraftingDiagramID = table.Column<int>(type: "int", nullable: true),
                    CraftingDiagramComponentID = table.Column<int>(type: "int", nullable: true),
                    SubstanceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmunitionDiagramComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AmmunitionDiagramComponents_AmmunitionDiagrams_AmmunitionDiagramID",
                        column: x => x.AmmunitionDiagramID,
                        principalTable: "AmmunitionDiagrams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmmunitionDiagramComponents_Ingredients_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AmmunitionDiagramComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraf~",
                        columns: x => new { x.CraftingDiagramComponentCraftingDiagramID, x.CraftingDiagramComponentCraftingComponentID },
                        principalTable: "CraftingDiagramComponents",
                        principalColumns: new[] { "CraftingDiagramID", "CraftingComponentID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionDiagramComponents_AmmunitionDiagramID",
                table: "AmmunitionDiagramComponents",
                column: "AmmunitionDiagramID");

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionDiagramComponents_SubstanceID",
                table: "AmmunitionDiagramComponents",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "AmmunitionDiagramComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" });

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionDiagrams_AmmunitionID",
                table: "AmmunitionDiagrams",
                column: "AmmunitionID");
        }
    }
}
