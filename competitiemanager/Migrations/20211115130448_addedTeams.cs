using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace competitiemanager.Migrations
{
    public partial class addedTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Competitions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "StartDateAndTime",
                value: new DateTime(2021, 11, 15, 14, 4, 48, 153, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "StartDateAndTime",
                value: new DateTime(2021, 11, 15, 14, 4, 48, 157, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "StartDateAndTime",
                value: new DateTime(2021, 11, 15, 14, 4, 48, 157, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Location", "Name" },
                values: new object[,]
                {
                    { 3, "locatie C", "Team C" },
                    { 4, "locatie D", "Team D" },
                    { 5, "locatie E", "Team E" },
                    { 6, "locatie F", "Team F" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Competitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "StartDateAndTime",
                value: new DateTime(2021, 11, 1, 10, 11, 37, 183, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "StartDateAndTime",
                value: new DateTime(2021, 11, 1, 10, 11, 37, 189, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "StartDateAndTime",
                value: new DateTime(2021, 11, 1, 10, 11, 37, 189, DateTimeKind.Local).AddTicks(4369));
        }
    }
}
