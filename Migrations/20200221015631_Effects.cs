using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class Effects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmorEffect_Armors_ArmorID",
                table: "ArmorEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorEffect_Effects_EffectID",
                table: "ArmorEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponEffect_Effects_EffectID",
                table: "WeaponEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponEffect_Weapons_WeaponID",
                table: "WeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponEffect",
                table: "WeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArmorEffect",
                table: "ArmorEffect");

            migrationBuilder.RenameTable(
                name: "WeaponEffect",
                newName: "WeaponEffects");

            migrationBuilder.RenameTable(
                name: "ArmorEffect",
                newName: "ArmorEffects");

            migrationBuilder.RenameIndex(
                name: "IX_WeaponEffect_EffectID",
                table: "WeaponEffects",
                newName: "IX_WeaponEffects_EffectID");

            migrationBuilder.RenameIndex(
                name: "IX_ArmorEffect_EffectID",
                table: "ArmorEffects",
                newName: "IX_ArmorEffects_EffectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponEffects",
                table: "WeaponEffects",
                columns: new[] { "WeaponID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArmorEffects",
                table: "ArmorEffects",
                columns: new[] { "ArmorID", "EffectID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorEffects_Armors_ArmorID",
                table: "ArmorEffects",
                column: "ArmorID",
                principalTable: "Armors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorEffects_Effects_EffectID",
                table: "ArmorEffects",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponEffects_Effects_EffectID",
                table: "WeaponEffects",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponEffects_Weapons_WeaponID",
                table: "WeaponEffects",
                column: "WeaponID",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmorEffects_Armors_ArmorID",
                table: "ArmorEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorEffects_Effects_EffectID",
                table: "ArmorEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponEffects_Effects_EffectID",
                table: "WeaponEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_WeaponEffects_Weapons_WeaponID",
                table: "WeaponEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeaponEffects",
                table: "WeaponEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArmorEffects",
                table: "ArmorEffects");

            migrationBuilder.RenameTable(
                name: "WeaponEffects",
                newName: "WeaponEffect");

            migrationBuilder.RenameTable(
                name: "ArmorEffects",
                newName: "ArmorEffect");

            migrationBuilder.RenameIndex(
                name: "IX_WeaponEffects_EffectID",
                table: "WeaponEffect",
                newName: "IX_WeaponEffect_EffectID");

            migrationBuilder.RenameIndex(
                name: "IX_ArmorEffects_EffectID",
                table: "ArmorEffect",
                newName: "IX_ArmorEffect_EffectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeaponEffect",
                table: "WeaponEffect",
                columns: new[] { "WeaponID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArmorEffect",
                table: "ArmorEffect",
                columns: new[] { "ArmorID", "EffectID" });

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorEffect_Armors_ArmorID",
                table: "ArmorEffect",
                column: "ArmorID",
                principalTable: "Armors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorEffect_Effects_EffectID",
                table: "ArmorEffect",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponEffect_Effects_EffectID",
                table: "WeaponEffect",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponEffect_Weapons_WeaponID",
                table: "WeaponEffect",
                column: "WeaponID",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
