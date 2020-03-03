using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedAmmoEffect3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionEffect_Ammunitions_AmmunitionID",
                table: "AmmunitionEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionEffect_Effects_EffectID",
                table: "AmmunitionEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AmmunitionEffect",
                table: "AmmunitionEffect");

            migrationBuilder.RenameTable(
                name: "AmmunitionEffect",
                newName: "AmmunitionEffects");

            migrationBuilder.RenameIndex(
                name: "IX_AmmunitionEffect_EffectID",
                table: "AmmunitionEffects",
                newName: "IX_AmmunitionEffects_EffectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AmmunitionEffects",
                table: "AmmunitionEffects",
                columns: new[] { "AmmunitionID", "EffectID" });

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionEffects_Ammunitions_AmmunitionID",
                table: "AmmunitionEffects",
                column: "AmmunitionID",
                principalTable: "Ammunitions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionEffects_Effects_EffectID",
                table: "AmmunitionEffects",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionEffects_Ammunitions_AmmunitionID",
                table: "AmmunitionEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_AmmunitionEffects_Effects_EffectID",
                table: "AmmunitionEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AmmunitionEffects",
                table: "AmmunitionEffects");

            migrationBuilder.RenameTable(
                name: "AmmunitionEffects",
                newName: "AmmunitionEffect");

            migrationBuilder.RenameIndex(
                name: "IX_AmmunitionEffects_EffectID",
                table: "AmmunitionEffect",
                newName: "IX_AmmunitionEffect_EffectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AmmunitionEffect",
                table: "AmmunitionEffect",
                columns: new[] { "AmmunitionID", "EffectID" });

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionEffect_Ammunitions_AmmunitionID",
                table: "AmmunitionEffect",
                column: "AmmunitionID",
                principalTable: "Ammunitions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmmunitionEffect_Effects_EffectID",
                table: "AmmunitionEffect",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
