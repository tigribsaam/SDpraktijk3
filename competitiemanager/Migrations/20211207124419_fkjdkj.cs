using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace competitiemanager.Migrations
{
    public partial class fkjdkj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "StartDateAndTime",
                value: new DateTime(2021, 12, 7, 13, 44, 18, 88, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "StartDateAndTime",
                value: new DateTime(2021, 12, 7, 13, 44, 18, 93, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "StartDateAndTime",
                value: new DateTime(2021, 12, 7, 13, 44, 18, 93, DateTimeKind.Local).AddTicks(2709));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "StartDateAndTime",
                value: new DateTime(2021, 12, 7, 13, 41, 16, 728, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "StartDateAndTime",
                value: new DateTime(2021, 12, 7, 13, 41, 16, 736, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "StartDateAndTime",
                value: new DateTime(2021, 12, 7, 13, 41, 16, 736, DateTimeKind.Local).AddTicks(9722));
        }
    }
}
