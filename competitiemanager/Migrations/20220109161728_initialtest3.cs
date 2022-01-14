using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace competitiemanager.Migrations
{
    public partial class initialtest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "StartDateAndTime",
                value: new DateTime(2022, 1, 8, 17, 17, 27, 853, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "StartDateAndTime",
                value: new DateTime(2022, 1, 15, 17, 17, 27, 856, DateTimeKind.Local).AddTicks(8639));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "StartDateAndTime",
                value: new DateTime(2022, 1, 8, 15, 32, 39, 102, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "StartDateAndTime",
                value: new DateTime(2022, 1, 15, 15, 32, 39, 106, DateTimeKind.Local).AddTicks(825));
        }
    }
}
