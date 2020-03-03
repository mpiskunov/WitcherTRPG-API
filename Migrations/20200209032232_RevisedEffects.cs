using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class RevisedEffects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmors_EffectPackages_EffectPackageID",
                table: "CharacterArmors");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmors_EffectPackageID",
                table: "CharacterArmors");

            migrationBuilder.DropColumn(
                name: "EffectPackageID",
                table: "CharacterArmors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EffectPackageID",
                table: "CharacterArmors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmors_EffectPackageID",
                table: "CharacterArmors",
                column: "EffectPackageID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmors_EffectPackages_EffectPackageID",
                table: "CharacterArmors",
                column: "EffectPackageID",
                principalTable: "EffectPackages",
                principalColumn: "EffectPackageID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
