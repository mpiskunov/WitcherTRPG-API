using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedAmmoEffect2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmmunitionEffect",
                columns: table => new
                {
                    AmmunitionID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmunitionEffect", x => new { x.AmmunitionID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_AmmunitionEffect_Ammunitions_AmmunitionID",
                        column: x => x.AmmunitionID,
                        principalTable: "Ammunitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmmunitionEffect_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionEffect_EffectID",
                table: "AmmunitionEffect",
                column: "EffectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmmunitionEffect");
        }
    }
}
