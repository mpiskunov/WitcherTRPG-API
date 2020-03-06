using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class removedcompositetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillPackages_Skills_SkillID",
                table: "SkillPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillPackages",
                table: "SkillPackages");

            migrationBuilder.AlterColumn<int>(
                name: "SkillID",
                table: "SkillPackages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "SkillPackages",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillPackages",
                table: "SkillPackages",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPackages_ProfessionID",
                table: "SkillPackages",
                column: "ProfessionID");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillPackages_Skills_SkillID",
                table: "SkillPackages",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillPackages_Skills_SkillID",
                table: "SkillPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillPackages",
                table: "SkillPackages");

            migrationBuilder.DropIndex(
                name: "IX_SkillPackages_ProfessionID",
                table: "SkillPackages");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "SkillPackages");

            migrationBuilder.AlterColumn<int>(
                name: "SkillID",
                table: "SkillPackages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillPackages",
                table: "SkillPackages",
                columns: new[] { "ProfessionID", "SkillID" });

            migrationBuilder.AddForeignKey(
                name: "FK_SkillPackages_Skills_SkillID",
                table: "SkillPackages",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
