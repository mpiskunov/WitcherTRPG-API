using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class AddedSourceTableMonsterstats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Campaigns_CampaignID",
                table: "CharacterSheets");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_CampaignID",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Affectations",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "CampaignID",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Clothing",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Encumbrance",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "FeelingsOnPeople",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "HairStyle",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Personality",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "ValuedPerson",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "Vigor",
                table: "CharacterSheets");

            migrationBuilder.CreateTable(
                name: "DerivedStatistic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DerivedStatisticID = table.Column<int>(nullable: false),
                    DerivedStatisticCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerivedStatistic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonsterStatistics",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false),
                    StatisticID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterStatistics", x => new { x.MonsterID, x.StatisticID });
                    table.ForeignKey(
                        name: "FK_MonsterStatistics_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterStatistics_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    IsOfficial = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDerivedStatistics",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    DerivedStatisticID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDerivedStatistics", x => new { x.CharacterSheetID, x.DerivedStatisticID });
                    table.ForeignKey(
                        name: "FK_CharacterDerivedStatistics_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDerivedStatistics_DerivedStatistic_DerivedStatisticID",
                        column: x => x.DerivedStatisticID,
                        principalTable: "DerivedStatistic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterDerivedStatistics",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false),
                    DerivedStatisticID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterDerivedStatistics", x => new { x.MonsterID, x.DerivedStatisticID });
                    table.ForeignKey(
                        name: "FK_MonsterDerivedStatistics_DerivedStatistic_DerivedStatisticID",
                        column: x => x.DerivedStatisticID,
                        principalTable: "DerivedStatistic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterDerivedStatistics_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDerivedStatistics_DerivedStatisticID",
                table: "CharacterDerivedStatistics",
                column: "DerivedStatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterDerivedStatistics_DerivedStatisticID",
                table: "MonsterDerivedStatistics",
                column: "DerivedStatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterStatistics_StatisticID",
                table: "MonsterStatistics",
                column: "StatisticID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterDerivedStatistics");

            migrationBuilder.DropTable(
                name: "MonsterDerivedStatistics");

            migrationBuilder.DropTable(
                name: "MonsterStatistics");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "DerivedStatistic");

            migrationBuilder.AddColumn<string>(
                name: "Affectations",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CampaignID",
                table: "CharacterSheets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Clothing",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Encumbrance",
                table: "CharacterSheets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "FeelingsOnPeople",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HairStyle",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Personality",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValuedPerson",
                table: "CharacterSheets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vigor",
                table: "CharacterSheets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_CampaignID",
                table: "CharacterSheets",
                column: "CampaignID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Campaigns_CampaignID",
                table: "CharacterSheets",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
