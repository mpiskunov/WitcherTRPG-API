using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedArmorCover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArmorCategoryID",
                table: "Armors");

            migrationBuilder.CreateTable(
                name: "ArmorCovers",
                columns: table => new
                {
                    ArmorID = table.Column<int>(nullable: false),
                    ArmorClassificationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorCovers", x => new { x.ArmorID, x.ArmorClassificationID });
                    table.ForeignKey(
                        name: "FK_ArmorCovers_Armors_ArmorID",
                        column: x => x.ArmorID,
                        principalTable: "Armors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorCovers");

            migrationBuilder.AddColumn<int>(
                name: "ArmorCategoryID",
                table: "Armors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
