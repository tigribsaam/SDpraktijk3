using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace competitiemanager.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotoScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamInComps",
                columns: table => new
                {
                    TeamInCompetitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CompetitionId = table.Column<int>(type: "int", nullable: false),
                    GamesPlayed = table.Column<int>(type: "int", nullable: false),
                    GamesWon = table.Column<int>(type: "int", nullable: false),
                    GamesLost = table.Column<int>(type: "int", nullable: false),
                    GamesTied = table.Column<int>(type: "int", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    CounterGoals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInComps", x => x.TeamInCompetitionId);
                    table.ForeignKey(
                        name: "FK_TeamInComps_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamInComps_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionId = table.Column<int>(type: "int", nullable: false),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    AwayTeamId = table.Column<int>(type: "int", nullable: false),
                    StartDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoalsHome = table.Column<int>(type: "int", nullable: false),
                    GoalsAway = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_TeamInComps_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "TeamInComps",
                        principalColumn: "TeamInCompetitionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_TeamInComps_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "TeamInComps",
                        principalColumn: "TeamInCompetitionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    BetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Prediction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.BetId);
                    table.ForeignKey(
                        name: "FK_Bets_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "CompetitionId", "Name" },
                values: new object[,]
                {
                    { 1, "test competitie 1" },
                    { 2, "test competitie 2" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "locatie A", "De Winnaars" },
                    { 2, "locatie B", "De Verliezers" },
                    { 3, "locatie C", "Team C" },
                    { 4, "locatie D", "Team D" },
                    { 5, "locatie E", "Team E" },
                    { 6, "locatie F", "Team F" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Role", "TotoScore" },
                values: new object[] { 1, "Ad Random", null, 0 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, "speler 1", 1 },
                    { 2, "speler 2", 1 },
                    { 3, "speler 3", 1 },
                    { 4, "speler 4", 1 },
                    { 5, "speler 5", 1 },
                    { 6, "speler 6", 1 },
                    { 7, "speler 7", 2 },
                    { 8, "speler 8", 2 },
                    { 9, "speler 9", 2 },
                    { 10, "speler 10", 2 },
                    { 11, "speler 11", 2 },
                    { 12, "speler 12", 2 }
                });

            migrationBuilder.InsertData(
                table: "TeamInComps",
                columns: new[] { "TeamInCompetitionId", "CompetitionId", "CounterGoals", "GamesLost", "GamesPlayed", "GamesTied", "GamesWon", "Goals", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, 0, 0, 0, 0, 0, 0, 1 },
                    { 2, 1, 0, 0, 0, 0, 0, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "AwayTeamId", "CompetitionId", "GoalsAway", "GoalsHome", "HomeTeamId", "StartDateAndTime", "Status" },
                values: new object[] { 1, 2, 1, 0, 0, 1, new DateTime(2021, 11, 19, 11, 19, 4, 459, DateTimeKind.Local).AddTicks(2929), 0 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "AwayTeamId", "CompetitionId", "GoalsAway", "GoalsHome", "HomeTeamId", "StartDateAndTime", "Status" },
                values: new object[] { 2, 1, 1, 0, 0, 2, new DateTime(2021, 11, 19, 11, 19, 4, 464, DateTimeKind.Local).AddTicks(3486), 0 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "AwayTeamId", "CompetitionId", "GoalsAway", "GoalsHome", "HomeTeamId", "StartDateAndTime", "Status" },
                values: new object[] { 3, 1, 2, 3, 0, 2, new DateTime(2021, 11, 19, 11, 19, 4, 464, DateTimeKind.Local).AddTicks(3562), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_GameId",
                table: "Bets",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_UserId",
                table: "Bets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_AwayTeamId",
                table: "Games",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CompetitionId",
                table: "Games",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeTeamId",
                table: "Games",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInComps_CompetitionId",
                table: "TeamInComps",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInComps_TeamId",
                table: "TeamInComps",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TeamInComps");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
