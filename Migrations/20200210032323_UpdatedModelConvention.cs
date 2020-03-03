using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class UpdatedModelConvention : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffect_Effects_EffectID",
                table: "CharacterArmorEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBomb_Bomb_BombID",
                table: "CharacterBomb");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBomb_CharacterSheets_CharacterSheetID",
                table: "CharacterBomb");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTrap_CharacterSheets_CharacterSheetID",
                table: "CharacterTrap");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTrap_Trap_TrapID",
                table: "CharacterTrap");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffect_Effects_EffectID",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trap",
                table: "Trap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterWeaponEffect",
                table: "CharacterWeaponEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterTrap",
                table: "CharacterTrap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterBomb",
                table: "CharacterBomb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmorEffect",
                table: "CharacterArmorEffect");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bomb",
                table: "Bomb");

            migrationBuilder.RenameTable(
                name: "Trap",
                newName: "Traps");

            migrationBuilder.RenameTable(
                name: "CharacterWeaponEffect",
                newName: "CharacterWeaponEffects");

            migrationBuilder.RenameTable(
                name: "CharacterTrap",
                newName: "CharacterTraps");

            migrationBuilder.RenameTable(
                name: "CharacterBomb",
                newName: "CharacterBombs");

            migrationBuilder.RenameTable(
                name: "CharacterArmorEffect",
                newName: "CharacterArmorEffects");

            migrationBuilder.RenameTable(
                name: "Bomb",
                newName: "Bombs");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterWeaponEffect_EffectID",
                table: "CharacterWeaponEffects",
                newName: "IX_CharacterWeaponEffects_EffectID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterTrap_TrapID",
                table: "CharacterTraps",
                newName: "IX_CharacterTraps_TrapID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBomb_BombID",
                table: "CharacterBombs",
                newName: "IX_CharacterBombs_BombID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterArmorEffect_EffectID",
                table: "CharacterArmorEffects",
                newName: "IX_CharacterArmorEffects_EffectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Traps",
                table: "Traps",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterWeaponEffects",
                table: "CharacterWeaponEffects",
                columns: new[] { "CharacterWeaponID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterTraps",
                table: "CharacterTraps",
                columns: new[] { "CharacterSheetID", "TrapID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterBombs",
                table: "CharacterBombs",
                columns: new[] { "CharacterSheetID", "BombID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmorEffects",
                table: "CharacterArmorEffects",
                columns: new[] { "CharacterArmorID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bombs",
                table: "Bombs",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "AmmunitionDiagrams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmunitionID = table.Column<int>(nullable: false),
                    CraftDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
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
                name: "BombFormulaes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BombID = table.Column<int>(nullable: false),
                    CraftDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BombFormulaes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Glyphs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glyphs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Runes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TrapDiagrams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrapID = table.Column<int>(nullable: false),
                    CraftDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrapDiagrams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrapDiagrams_Traps_TrapID",
                        column: x => x.TrapID,
                        principalTable: "Traps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmmunitionDiagramComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmunitionDiagramID = table.Column<int>(nullable: false),
                    CraftingDiagramComponentID = table.Column<int>(nullable: true),
                    SubstanceID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    CraftingDiagramComponentCraftingDiagramID = table.Column<int>(nullable: true),
                    CraftingDiagramComponentCraftingComponentID = table.Column<int>(nullable: true)
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
                        name: "FK_AmmunitionDiagramComponents_Substances_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Substances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AmmunitionDiagramComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraf~",
                        columns: x => new { x.CraftingDiagramComponentCraftingDiagramID, x.CraftingDiagramComponentCraftingComponentID },
                        principalTable: "CraftingDiagramComponents",
                        principalColumns: new[] { "CraftingDiagramID", "CraftingComponentID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BombFormulaeComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BombDiagramID = table.Column<int>(nullable: false),
                    CraftingDiagramComponentID = table.Column<int>(nullable: true),
                    SubstanceID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    BombFormulaeID = table.Column<int>(nullable: true),
                    CraftingDiagramComponentCraftingDiagramID = table.Column<int>(nullable: true),
                    CraftingDiagramComponentCraftingComponentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BombFormulaeComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BombFormulaeComponents_BombFormulaes_BombFormulaeID",
                        column: x => x.BombFormulaeID,
                        principalTable: "BombFormulaes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BombFormulaeComponents_Substances_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Substances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BombFormulaeComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingC~",
                        columns: x => new { x.CraftingDiagramComponentCraftingDiagramID, x.CraftingDiagramComponentCraftingComponentID },
                        principalTable: "CraftingDiagramComponents",
                        principalColumns: new[] { "CraftingDiagramID", "CraftingComponentID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterGlyphs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    GlyphID = table.Column<int>(nullable: false),
                    CharacterArmorID = table.Column<int>(nullable: true),
                    IsEquipped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterGlyphs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterGlyphs_CharacterArmors_CharacterArmorID",
                        column: x => x.CharacterArmorID,
                        principalTable: "CharacterArmors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterGlyphs_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterGlyphs_Glyphs_GlyphID",
                        column: x => x.GlyphID,
                        principalTable: "Glyphs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterRunes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    RuneID = table.Column<int>(nullable: false),
                    CharacterWeaponID = table.Column<int>(nullable: true),
                    IsEquipped = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRunes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterRunes_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterRunes_CharacterWeapons_CharacterWeaponID",
                        column: x => x.CharacterWeaponID,
                        principalTable: "CharacterWeapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterRunes_Runes_RuneID",
                        column: x => x.RuneID,
                        principalTable: "Runes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrapDiagramComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrapDiagramID = table.Column<int>(nullable: false),
                    CraftingDiagramComponentID = table.Column<int>(nullable: true),
                    SubstanceID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    CraftingDiagramComponentCraftingDiagramID = table.Column<int>(nullable: true),
                    CraftingDiagramComponentCraftingComponentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrapDiagramComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrapDiagramComponents_Substances_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Substances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrapDiagramComponents_TrapDiagrams_TrapDiagramID",
                        column: x => x.TrapDiagramID,
                        principalTable: "TrapDiagrams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrapDiagramComponents_CraftingDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingCo~",
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

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_BombFormulaeID",
                table: "BombFormulaeComponents",
                column: "BombFormulaeID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_SubstanceID",
                table: "BombFormulaeComponents",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "BombFormulaeComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGlyphs_CharacterArmorID",
                table: "CharacterGlyphs",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGlyphs_CharacterSheetID",
                table: "CharacterGlyphs",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGlyphs_GlyphID",
                table: "CharacterGlyphs",
                column: "GlyphID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRunes_CharacterSheetID",
                table: "CharacterRunes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRunes_CharacterWeaponID",
                table: "CharacterRunes",
                column: "CharacterWeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRunes_RuneID",
                table: "CharacterRunes",
                column: "RuneID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_SubstanceID",
                table: "TrapDiagramComponents",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_TrapDiagramID",
                table: "TrapDiagramComponents",
                column: "TrapDiagramID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_CraftingDiagramComponentCraftingDiagramID_CraftingDiagramComponentCraftingComponentID",
                table: "TrapDiagramComponents",
                columns: new[] { "CraftingDiagramComponentCraftingDiagramID", "CraftingDiagramComponentCraftingComponentID" });

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagrams_TrapID",
                table: "TrapDiagrams",
                column: "TrapID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffects_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEffects",
                column: "CharacterArmorID",
                principalTable: "CharacterArmors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffects_Effects_EffectID",
                table: "CharacterArmorEffects",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBombs_Bombs_BombID",
                table: "CharacterBombs",
                column: "BombID",
                principalTable: "Bombs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBombs_CharacterSheets_CharacterSheetID",
                table: "CharacterBombs",
                column: "CharacterSheetID",
                principalTable: "CharacterSheets",
                principalColumn: "CharacterSheetID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTraps_CharacterSheets_CharacterSheetID",
                table: "CharacterTraps",
                column: "CharacterSheetID",
                principalTable: "CharacterSheets",
                principalColumn: "CharacterSheetID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTraps_Traps_TrapID",
                table: "CharacterTraps",
                column: "TrapID",
                principalTable: "Traps",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffects_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterArmorEffects_Effects_EffectID",
                table: "CharacterArmorEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBombs_Bombs_BombID",
                table: "CharacterBombs");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBombs_CharacterSheets_CharacterSheetID",
                table: "CharacterBombs");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTraps_CharacterSheets_CharacterSheetID",
                table: "CharacterTraps");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterTraps_Traps_TrapID",
                table: "CharacterTraps");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffects_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterWeaponEffects_Effects_EffectID",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropTable(
                name: "AmmunitionDiagramComponents");

            migrationBuilder.DropTable(
                name: "BombFormulaeComponents");

            migrationBuilder.DropTable(
                name: "CharacterGlyphs");

            migrationBuilder.DropTable(
                name: "CharacterRunes");

            migrationBuilder.DropTable(
                name: "TrapDiagramComponents");

            migrationBuilder.DropTable(
                name: "AmmunitionDiagrams");

            migrationBuilder.DropTable(
                name: "BombFormulaes");

            migrationBuilder.DropTable(
                name: "Glyphs");

            migrationBuilder.DropTable(
                name: "Runes");

            migrationBuilder.DropTable(
                name: "TrapDiagrams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Traps",
                table: "Traps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterWeaponEffects",
                table: "CharacterWeaponEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterTraps",
                table: "CharacterTraps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterBombs",
                table: "CharacterBombs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterArmorEffects",
                table: "CharacterArmorEffects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bombs",
                table: "Bombs");

            migrationBuilder.RenameTable(
                name: "Traps",
                newName: "Trap");

            migrationBuilder.RenameTable(
                name: "CharacterWeaponEffects",
                newName: "CharacterWeaponEffect");

            migrationBuilder.RenameTable(
                name: "CharacterTraps",
                newName: "CharacterTrap");

            migrationBuilder.RenameTable(
                name: "CharacterBombs",
                newName: "CharacterBomb");

            migrationBuilder.RenameTable(
                name: "CharacterArmorEffects",
                newName: "CharacterArmorEffect");

            migrationBuilder.RenameTable(
                name: "Bombs",
                newName: "Bomb");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterWeaponEffects_EffectID",
                table: "CharacterWeaponEffect",
                newName: "IX_CharacterWeaponEffect_EffectID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterTraps_TrapID",
                table: "CharacterTrap",
                newName: "IX_CharacterTrap_TrapID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBombs_BombID",
                table: "CharacterBomb",
                newName: "IX_CharacterBomb_BombID");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterArmorEffects_EffectID",
                table: "CharacterArmorEffect",
                newName: "IX_CharacterArmorEffect_EffectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trap",
                table: "Trap",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterWeaponEffect",
                table: "CharacterWeaponEffect",
                columns: new[] { "CharacterWeaponID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterTrap",
                table: "CharacterTrap",
                columns: new[] { "CharacterSheetID", "TrapID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterBomb",
                table: "CharacterBomb",
                columns: new[] { "CharacterSheetID", "BombID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterArmorEffect",
                table: "CharacterArmorEffect",
                columns: new[] { "CharacterArmorID", "EffectID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bomb",
                table: "Bomb",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorID",
                table: "CharacterArmorEffect",
                column: "CharacterArmorID",
                principalTable: "CharacterArmors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterArmorEffect_Effects_EffectID",
                table: "CharacterArmorEffect",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBomb_Bomb_BombID",
                table: "CharacterBomb",
                column: "BombID",
                principalTable: "Bomb",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBomb_CharacterSheets_CharacterSheetID",
                table: "CharacterBomb",
                column: "CharacterSheetID",
                principalTable: "CharacterSheets",
                principalColumn: "CharacterSheetID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTrap_CharacterSheets_CharacterSheetID",
                table: "CharacterTrap",
                column: "CharacterSheetID",
                principalTable: "CharacterSheets",
                principalColumn: "CharacterSheetID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterTrap_Trap_TrapID",
                table: "CharacterTrap",
                column: "TrapID",
                principalTable: "Trap",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponID",
                table: "CharacterWeaponEffect",
                column: "CharacterWeaponID",
                principalTable: "CharacterWeapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterWeaponEffect_Effects_EffectID",
                table: "CharacterWeaponEffect",
                column: "EffectID",
                principalTable: "Effects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
