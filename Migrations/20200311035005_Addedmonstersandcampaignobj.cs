using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class Addedmonstersandcampaignobj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignID",
                table: "CharacterSheets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CampaignMonsters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    INT = table.Column<int>(nullable: false),
                    REF = table.Column<int>(nullable: false),
                    DEX = table.Column<int>(nullable: false),
                    BODY = table.Column<int>(nullable: false),
                    SPD = table.Column<int>(nullable: false),
                    EMP = table.Column<int>(nullable: false),
                    CRA = table.Column<int>(nullable: false),
                    WILL = table.Column<int>(nullable: false),
                    LUCK = table.Column<int>(nullable: false),
                    STUN = table.Column<int>(nullable: false),
                    RUN = table.Column<int>(nullable: false),
                    LEAP = table.Column<int>(nullable: false),
                    STA = table.Column<int>(nullable: false),
                    ENC = table.Column<int>(nullable: false),
                    REC = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    Vigor = table.Column<int>(nullable: false),
                    IsDead = table.Column<bool>(nullable: false),
                    CurrentLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignMonsters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CampaignMonsters_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CampaignCovers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignID = table.Column<int>(nullable: false),
                    CommonCoverID = table.Column<int>(nullable: false),
                    StoppingPower = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCovers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CampaignCovers_Campaigns_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignCovers_CommonCovers_CommonCoverID",
                        column: x => x.CommonCoverID,
                        principalTable: "CommonCovers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampaignNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deleted = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CampaignID = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CampaignNotes_Campaigns_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_CampaignID",
                table: "CharacterSheets",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCovers_CampaignID",
                table: "CampaignCovers",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCovers_CommonCoverID",
                table: "CampaignCovers",
                column: "CommonCoverID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignMonsters_MonsterID",
                table: "CampaignMonsters",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignNotes_CampaignID",
                table: "CampaignNotes",
                column: "CampaignID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSheets_Campaigns_CampaignID",
                table: "CharacterSheets",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSheets_Campaigns_CampaignID",
                table: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "CampaignCovers");

            migrationBuilder.DropTable(
                name: "CampaignMonsters");

            migrationBuilder.DropTable(
                name: "CampaignNotes");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSheets_CampaignID",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "CampaignID",
                table: "CharacterSheets");
        }
    }
}
