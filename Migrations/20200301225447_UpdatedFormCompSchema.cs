using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class UpdatedFormCompSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormulaeComponents_Substances_SubstanceID",
                table: "FormulaeComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormulaeComponents",
                table: "FormulaeComponents");

            migrationBuilder.DropIndex(
                name: "IX_FormulaeComponents_SubstanceID",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "SubstanceID",
                table: "FormulaeComponents");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "FormulaeComponents",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SubstanceCategoryID",
                table: "FormulaeComponents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormulaeComponents",
                table: "FormulaeComponents",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaeComponents_FormulaeID",
                table: "FormulaeComponents",
                column: "FormulaeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormulaeComponents",
                table: "FormulaeComponents");

            migrationBuilder.DropIndex(
                name: "IX_FormulaeComponents_FormulaeID",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "FormulaeComponents");

            migrationBuilder.DropColumn(
                name: "SubstanceCategoryID",
                table: "FormulaeComponents");

            migrationBuilder.AddColumn<int>(
                name: "SubstanceID",
                table: "FormulaeComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormulaeComponents",
                table: "FormulaeComponents",
                columns: new[] { "FormulaeID", "SubstanceID" });

            migrationBuilder.CreateIndex(
                name: "IX_FormulaeComponents_SubstanceID",
                table: "FormulaeComponents",
                column: "SubstanceID");

            migrationBuilder.AddForeignKey(
                name: "FK_FormulaeComponents_Substances_SubstanceID",
                table: "FormulaeComponents",
                column: "SubstanceID",
                principalTable: "Substances",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
