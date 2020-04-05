using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class addedcritsandfumbles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CriticalLevelCategory",
                table: "CriticalLevels");

           migrationBuilder.AddColumn<int>(
                name: "CriticalWoundType",
                table: "CriticalLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MonsterAnatomyType",
                table: "CriticalLevels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CriticalTables",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roll = table.Column<string>(nullable: true),
                    RollType = table.Column<string>(nullable: true),
                    EffectTitle = table.Column<string>(nullable: true),
                    EffectDescription = table.Column<string>(nullable: true),
                    Stabilized = table.Column<string>(nullable: true),
                    Treated = table.Column<string>(nullable: true),
                    CriticalWoundType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriticalTables", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fumbles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roll = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    FumbleType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fumbles", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CriticalTables");

            migrationBuilder.DropTable(
                name: "Fumbles");

            migrationBuilder.DropColumn(
                name: "CriticalWoundType",
                table: "CriticalLevels");


            migrationBuilder.AddColumn<int>(
                name: "MonsterAnatomyType",
                table: "CriticalLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
