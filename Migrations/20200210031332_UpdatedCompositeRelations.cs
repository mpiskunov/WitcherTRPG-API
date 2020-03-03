using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class UpdatedCompositeRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEnhancements_CharacterArmors_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMountOutfits_CharacterMount_Vehicles_CharacterMount_VehicleCharacterSheetID_CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponCharacterSheetID_CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterWeapons",
                table: "CharacterWeapons");

            migrationBuilder.DropIndex(
                name: "IX_CharacterWeaponEffect_CharacterWeaponCharacterSheetID_CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterMountOutfits",
                table: "CharacterMountOutfits");

            migrationBuilder.DropIndex(
                name: "IX_CharacterMountOutfits_CharacterMount_VehicleCharacterSheetID_CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterMount_Vehicles",
                table: "CharacterMount_Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterEffects",
                table: "CharacterEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmors",
                table: "CharacterArmors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmorEnhancements",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmorEnhancements_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmorEffect_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEffect");

            migrationBuilder.DropColumn(
                name: "CharacterWeaponCharacterSheetID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropColumn(
                name: "CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropColumn(
                name: "CharacterMount_VehicleCharacterSheetID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropColumn(
                name: "CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropColumn(
                name: "CharacterArmorArmorID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "CharacterArmorCharacterSheetID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "CharacterArmorArmorID",
                table: "CharacterArmorEffect");

            migrationBuilder.DropColumn(
                name: "CharacterArmorCharacterSheetID",
                table: "CharacterArmorEffect");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterWeapons",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "CharacterSubstances",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "CharacterServices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterMountOutfits",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterMount_Vehicles",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "RetainedByMemory",
                table: "CharacterFormulaes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterEffects",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterArmors",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CharacterArmorEnhancements",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterWeapons",
                table: "CharacterWeapons",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterMountOutfits",
                table: "CharacterMountOutfits",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterMount_Vehicles",
                table: "CharacterMount_Vehicles",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterEffects",
                table: "CharacterEffects",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmors",
                table: "CharacterArmors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmorEnhancements",
                table: "CharacterArmorEnhancements",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Bomb",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AttackType = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bomb", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trap",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterBomb",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    BombID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterBomb", x => new { x.CharacterSheetID, x.BombID });
                    table.ForeignKey(
                        name: "FK_CharacterBomb_Bomb_BombID",
                        column: x => x.BombID,
                        principalTable: "Bomb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterBomb_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTrap",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    TrapID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTrap", x => new { x.CharacterSheetID, x.TrapID });
                    table.ForeignKey(
                        name: "FK_CharacterTrap_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTrap_Trap_TrapID",
                        column: x => x.TrapID,
                        principalTable: "Trap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeapons_CharacterSheetID",
                table: "CharacterWeapons",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMountOutfits_CharacterMount_VehicleID",
                table: "CharacterMountOutfits",
                column: "CharacterMount_VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMount_Vehicles_CharacterSheetID",
                table: "CharacterMount_Vehicles",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEffects_CharacterSheetID",
                table: "CharacterEffects",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmors_CharacterSheetID",
                table: "CharacterArmors",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_CharacterArmorID",
                table: "CharacterArmorEnhancements",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_CharacterSheetID",
                table: "CharacterArmorEnhancements",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterBomb_BombID",
                table: "CharacterBomb",
                column: "BombID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTrap_TrapID",
                table: "CharacterTrap",
                column: "TrapID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEffect",
                column: "CharacterArmorID",
                principalTable: "CharacterArmors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEnhancements_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEnhancements",
                column: "CharacterArmorID",
                principalTable: "CharacterArmors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMountOutfits_CharacterMount_Vehicles_CharacterMount_VehicleID",
                table: "CharacterMountOutfits",
                column: "CharacterMount_VehicleID",
                principalTable: "CharacterMount_Vehicles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffect",
                column: "CharacterWeaponID",
                principalTable: "CharacterWeapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEnhancements_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMountOutfits_CharacterMount_Vehicles_CharacterMount_VehicleID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropTable(
                name: "CharacterBomb");

            migrationBuilder.DropTable(
                name: "CharacterTrap");

            migrationBuilder.DropTable(
                name: "Bomb");

            migrationBuilder.DropTable(
                name: "Trap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterWeapons",
                table: "CharacterWeapons");

            migrationBuilder.DropIndex(
                name: "IX_CharacterWeapons_CharacterSheetID",
                table: "CharacterWeapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterMountOutfits",
                table: "CharacterMountOutfits");

            migrationBuilder.DropIndex(
                name: "IX_CharacterMountOutfits_CharacterMount_VehicleID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterMount_Vehicles",
                table: "CharacterMount_Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_CharacterMount_Vehicles_CharacterSheetID",
                table: "CharacterMount_Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterEffects",
                table: "CharacterEffects");

            migrationBuilder.DropIndex(
                name: "IX_CharacterEffects_CharacterSheetID",
                table: "CharacterEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmors",
                table: "CharacterArmors");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmors_CharacterSheetID",
                table: "CharacterArmors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmorEnhancements",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmorEnhancements_CharacterArmorID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropIndex(
                name: "IX_CharacterArmorEnhancements_CharacterSheetID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterWeapons");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CharacterSubstances");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CharacterServices");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterMountOutfits");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterMount_Vehicles");

            migrationBuilder.DropColumn(
                name: "RetainedByMemory",
                table: "CharacterFormulaes");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterEffects");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterArmors");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CharacterArmorEnhancements");

            migrationBuilder.AddColumn<int>(
                name: "CharacterWeaponCharacterSheetID",
                table: "CharacterWeaponEffect",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterMount_VehicleCharacterSheetID",
                table: "CharacterMountOutfits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacterArmorArmorID",
                table: "CharacterArmorEnhancements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterArmorCharacterSheetID",
                table: "CharacterArmorEnhancements",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterArmorArmorID",
                table: "CharacterArmorEffect",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterArmorCharacterSheetID",
                table: "CharacterArmorEffect",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterWeapons",
                table: "CharacterWeapons",
                columns: new[] { "CharacterSheetID", "WeaponID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterMountOutfits",
                table: "CharacterMountOutfits",
                columns: new[] { "CharacterMount_VehicleID", "MountOutfitID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterMount_Vehicles",
                table: "CharacterMount_Vehicles",
                columns: new[] { "CharacterSheetID", "Mounts_VehicleID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterEffects",
                table: "CharacterEffects",
                columns: new[] { "CharacterSheetID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmors",
                table: "CharacterArmors",
                columns: new[] { "CharacterSheetID", "ArmorID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmorEnhancements",
                table: "CharacterArmorEnhancements",
                columns: new[] { "CharacterSheetID", "ArmorEnhancementID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeaponEffect_CharacterWeaponCharacterSheetID_CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect",
                columns: new[] { "CharacterWeaponCharacterSheetID", "CharacterWeaponWeaponID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMountOutfits_CharacterMount_VehicleCharacterSheetID_CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits",
                columns: new[] { "CharacterMount_VehicleCharacterSheetID", "CharacterMount_VehicleMounts_VehicleID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEnhancements",
                columns: new[] { "CharacterArmorCharacterSheetID", "CharacterArmorArmorID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEffect_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEffect",
                columns: new[] { "CharacterArmorCharacterSheetID", "CharacterArmorArmorID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEffect",
                columns: new[] { "CharacterArmorCharacterSheetID", "CharacterArmorArmorID" },
                principalTable: "CharacterArmors",
                principalColumns: new[] { "CharacterSheetID", "ArmorID" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEnhancements_CharacterArmors_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEnhancements",
                columns: new[] { "CharacterArmorCharacterSheetID", "CharacterArmorArmorID" },
                principalTable: "CharacterArmors",
                principalColumns: new[] { "CharacterSheetID", "ArmorID" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMountOutfits_CharacterMount_Vehicles_CharacterMount_VehicleCharacterSheetID_CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits",
                columns: new[] { "CharacterMount_VehicleCharacterSheetID", "CharacterMount_VehicleMounts_VehicleID" },
                principalTable: "CharacterMount_Vehicles",
                principalColumns: new[] { "CharacterSheetID", "Mounts_VehicleID" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponCharacterSheetID_CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect",
                columns: new[] { "CharacterWeaponCharacterSheetID", "CharacterWeaponWeaponID" },
                principalTable: "CharacterWeapons",
                principalColumns: new[] { "CharacterSheetID", "WeaponID" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
