using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class UpdatedEffectSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffects_Effects_EffectID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffects_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffects_Effects_EffectID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterWeaponEffects",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropIndex(
                name: "IX_CharacterWeaponEffects_EffectID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmorEffects",
                table: "CharacterArmorEffects");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmorEffects_EffectID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "EffectID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "CurrentDuration",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "CurrentValue",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "EffectID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "CurrentDuration",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "CurrentValue",
                table: "CharacterArmorEffects");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterWeaponEffects",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CharacterArmorID",
                table: "CharacterWeaponEffects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EffectDescription",
                table: "CharacterWeaponEffects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EffectName",
                table: "CharacterWeaponEffects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterArmorEffects",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "EffectDescription",
                table: "CharacterArmorEffects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EffectName",
                table: "CharacterArmorEffects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Effect",
                table: "AlchemicalItems",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterWeaponEffects",
                table: "CharacterWeaponEffects",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmorEffects",
                table: "CharacterArmorEffects",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ArmorEffect",
                columns: table => new
                {
                    ArmorID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEffect", x => new { x.ArmorID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_ArmorEffect_Armors_ArmorID",
                        column: x => x.ArmorID,
                        principalTable: "Armors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorEffect_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponEffect",
                columns: table => new
                {
                    WeaponID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponEffect", x => new { x.WeaponID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_WeaponEffect_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponEffect_Weapons_WeaponID",
                        column: x => x.WeaponID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeaponEffects_CharacterArmorID",
                table: "CharacterWeaponEffects",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEffects_CharacterArmorID",
                table: "CharacterArmorEffects",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEffect_EffectID",
                table: "ArmorEffect",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponEffect_EffectID",
                table: "WeaponEffect",
                column: "EffectID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffects_CharacterArmors_CharacterArmorID",
                table: "CharacterWeaponEffects",
                column: "CharacterArmorID",
                principalTable: "CharacterArmors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffects_CharacterArmors_CharacterArmorID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropTable(
                name: "ArmorEffect");

            migrationBuilder.DropTable(
                name: "WeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterWeaponEffects",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropIndex(
                name: "IX_CharacterWeaponEffects_CharacterArmorID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmorEffects",
                table: "CharacterArmorEffects");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmorEffects_CharacterArmorID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "CharacterArmorID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "EffectDescription",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "EffectName",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "EffectDescription",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "EffectName",
                table: "CharacterArmorEffects");

            migrationBuilder.DropColumn(
                name: "Effect",
                table: "AlchemicalItems");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Effects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Effects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Effects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EffectID",
                table: "CharacterWeaponEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentDuration",
                table: "CharacterWeaponEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentValue",
                table: "CharacterWeaponEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EffectID",
                table: "CharacterArmorEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentDuration",
                table: "CharacterArmorEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentValue",
                table: "CharacterArmorEffects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterWeaponEffects",
                table: "CharacterWeaponEffects",
                columns: new[] { "CharacterWeaponID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmorEffects",
                table: "CharacterArmorEffects",
                columns: new[] { "CharacterArmorID", "EffectID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeaponEffects_EffectID",
                table: "CharacterWeaponEffects",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEffects_EffectID",
                table: "CharacterArmorEffects",
                column: "EffectID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffects_Effects_EffectID",
                table: "CharacterArmorEffects",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffects_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffects",
                column: "CharacterWeaponID",
                principalTable: "CharacterWeapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffects_Effects_EffectID",
                table: "CharacterWeaponEffects",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
