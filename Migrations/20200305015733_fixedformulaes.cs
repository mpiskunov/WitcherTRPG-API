using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class fixedformulaes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_BombFormulaes_BombFormulaeID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_Ingredients_SubstanceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingC~",
                table: "BombFormulaeComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_TrapDiagramComponents_Ingredients_SubstanceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_TrapDiagramComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingCo~",
                table: "TrapDiagramComponents");

            migrationBuilder.DropIndex(
                name: "IX_TrapDiagramComponents_SubstanceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropIndex(
                name: "IX_TrapDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropIndex(
                name: "IX_BombFormulaeComponents_SubstanceID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropIndex(
                name: "IX_BombFormulaeComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramComponentCraftingComponentID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramComponentCraftingDiagramID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramComponentID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "SubstanceID",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "BombDiagramID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramComponentCraftingComponentID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramComponentCraftingDiagramID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "CraftingDiagramComponentID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "SubstanceID",
                table: "BombFormulaeComponents");

            migrationBuilder.AddColumn<string>(
                name: "ComponentName",
                table: "TrapDiagramComponents",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BombFormulaeID",
                table: "BombFormulaeComponents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComponentName",
                table: "BombFormulaeComponents",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BombFormulaeComponents_BombFormulaes_BombFormulaeID",
                table: "BombFormulaeComponents",
                column: "BombFormulaeID",
                principalTable: "BombFormulaes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BombFormulaeComponents_BombFormulaes_BombFormulaeID",
                table: "BombFormulaeComponents");

            migrationBuilder.DropColumn(
                name: "ComponentName",
                table: "TrapDiagramComponents");

            migrationBuilder.DropColumn(
                name: "ComponentName",
                table: "BombFormulaeComponents");

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramComponentCraftingComponentID",
                table: "TrapDiagramComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramComponentCraftingDiagramID",
                table: "TrapDiagramComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramComponentID",
                table: "TrapDiagramComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubstanceID",
                table: "TrapDiagramComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BombFormulaeID",
                table: "BombFormulaeComponents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BombDiagramID",
                table: "BombFormulaeComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramComponentCraftingComponentID",
                table: "BombFormulaeComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramComponentCraftingDiagramID",
                table: "BombFormulaeComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CraftingDiagramComponentID",
                table: "BombFormulaeComponents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubstanceID",
                table: "BombFormulaeComponents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_SubstanceID",
                table: "TrapDiagramComponents",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "TrapDiagramComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" });

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_SubstanceID",
                table: "BombFormulaeComponents",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "BombFormulaeComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" });

            migrationBuilder.AddForeignKey(
                name: "FK_BombFormulaeComponents_BombFormulaes_BombFormulaeID",
                table: "BombFormulaeComponents",
                column: "BombFormulaeID",
                principalTable: "BombFormulaes",
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
                name: "FK_BombFormulaeComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingC~",
                table: "BombFormulaeComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" },
                principalTable: "CraftingDiagramComponents",
                principalColumns: new[] { "CraftingDiagramID", "CraftingComponentID" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrapDiagramComponents_Ingredients_SubstanceID",
                table: "TrapDiagramComponents",
                column: "SubstanceID",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrapDiagramComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingCo~",
                table: "TrapDiagramComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" },
                principalTable: "CraftingDiagramComponents",
                principalColumns: new[] { "CraftingDiagramID", "CraftingComponentID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
