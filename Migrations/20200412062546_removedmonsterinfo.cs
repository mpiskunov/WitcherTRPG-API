using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class removedmonsterinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BODY",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "CRA",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "DEX",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "EMP",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "ENC",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "INT",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "LEAP",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "LUCK",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "REC",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "REF",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "RUN",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "SPD",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "STA",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "STUN",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Vigor",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "WILL",
                table: "Monsters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BODY",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CRA",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DEX",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EMP",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ENC",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "INT",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LEAP",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LUCK",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "REC",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "REF",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RUN",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SPD",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STA",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STUN",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vigor",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WILL",
                table: "Monsters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
