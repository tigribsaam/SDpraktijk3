using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace competitiemanager.Migrations
{
    public partial class seeddatecomp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GamesPlayedDraw",
                table: "TeamInComps",
                newName: "GamesTied");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "AwayTeamId", "CompetitionId", "GoalsAway", "GoalsHome", "HomeTeamId", "StartDateAndTime" },
                values: new object[] { 1, 2, null, 0, 0, 1, new DateTime(2021, 10, 31, 11, 0, 36, 742, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.InsertData(
                table: "TeamInComps",
                columns: new[] { "TeamInCompetitionId", "CompetitionId", "CounterGoals", "GamesLost", "GamesPlayed", "GamesTied", "GamesWon", "Goals", "TeamId" },
                values: new object[] { 1, 1, 0, 0, 0, 0, 0, 0, 1 });

            migrationBuilder.InsertData(
                table: "TeamInComps",
                columns: new[] { "TeamInCompetitionId", "CompetitionId", "CounterGoals", "GamesLost", "GamesPlayed", "GamesTied", "GamesWon", "Goals", "TeamId" },
                values: new object[] { 2, 1, 0, 0, 0, 0, 0, 0, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamInComps",
                keyColumn: "TeamInCompetitionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamInComps",
                keyColumn: "TeamInCompetitionId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "GamesTied",
                table: "TeamInComps",
                newName: "GamesPlayedDraw");
        }
    }
}
