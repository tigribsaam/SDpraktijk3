
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<TeamInCompetition> TeamInComps { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<User> UsersToto { get; set; }
        public DbSet<Player> Players { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .HasOne(e => e.HomeTeam)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                .HasOne(e => e.AwayTeam)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "De Winnaars",
                    Players = new List<Player>()
                    {   
                    },
                    Location = "locatie A"
                },
                new Team
                {
                    TeamId = 2,
                    Name = "De Verliezers",
                    Players = new List<Player>()
                    {   
                    },
                    Location = "locatie B"
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Team C",
                    Players = new List<Player>()
                    {
                    },
                    Location = "locatie C"
                },
                new Team
                {
                    TeamId = 4,
                    Name = "Team D",
                    Players = new List<Player>()
                    {
                    },
                    Location = "locatie D"
                },
                new Team
                {
                    TeamId = 5,
                    Name = "Team E",
                    Players = new List<Player>()
                    {
                    },
                    Location = "locatie E"
                },
                new Team
                {
                    TeamId = 6,
                    Name = "Team F",
                    Players = new List<Player>()
                    {
                    },
                    Location = "locatie F"
                });

            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 1, Name = "speler 1" , TeamId = 1},
                new Player { PlayerId = 2, Name = "speler 2" , TeamId = 1},
                new Player { PlayerId = 3, Name = "speler 3" , TeamId = 2},
                new Player { PlayerId = 4, Name = "speler 4" , TeamId = 2},
                new Player { PlayerId = 5, Name = "speler 5" , TeamId = 3},
                new Player { PlayerId = 6, Name = "speler 6" , TeamId = 3},
                new Player { PlayerId = 7, Name = "speler 7" , TeamId = 4},
                new Player { PlayerId = 8, Name = "speler 8" , TeamId = 4},
                new Player { PlayerId = 9, Name = "speler 9" , TeamId = 5},
                new Player { PlayerId = 10, Name = "speler 10" , TeamId = 5},
                new Player { PlayerId = 11, Name = "speler 11" , TeamId = 6},
                new Player { PlayerId = 12, Name = "speler 12" , TeamId = 6}
                );


            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Ad Random",
                    TotoScore = 20,
                    Bets = null
                },
                new User
                {
                    UserId = 2,
                    Name = "Arie Verdeci",
                    TotoScore = 45,
                    Bets = null
                },
                new User
                {
                    UserId = 3,
                    Name = "Beau Ter Ham",
                    TotoScore = 5,
                    Bets = null
                }
                );

            modelBuilder.Entity<Competition>().HasData(
                new Competition
                {
                    CompetitionId = 1,
                    Name = "Competitie 1",
                    Teams = new List<TeamInCompetition>(),
                    Games = new List<Game>()
                });

            modelBuilder.Entity<TeamInCompetition>().HasData(
                new TeamInCompetition
                {
                    TeamInCompetitionId = 1,
                    TeamId = 1,
                    CompetitionId = 1,
                    GamesPlayed = 1,
                    GamesWon = 1,
                    GamesLost = 0,
                    GamesTied = 0,
                    Goals = 2,
                    CounterGoals = 0,
                    Points = 3,
                    DoelSaldo = 2
                },
                new TeamInCompetition
                {
                    TeamInCompetitionId = 2,
                    TeamId = 2,
                    CompetitionId = 1,
                    GamesPlayed = 1,
                    GamesWon = 0,
                    GamesLost = 1,
                    GamesTied = 0,
                    Goals = 0,
                    CounterGoals = 2,
                    Points = 0,
                    DoelSaldo = -2
                }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    CompetitionId = 1,
                    HomeTeamId = 1,
                    AwayTeamId = 2,
                    StartDateAndTime = DateTime.Now.AddDays(-1),
                    Status = 3,
                    GoalsAway = 0,
                    GoalsHome = 2


                },
                new Game
                {
                    GameId = 2,
                    CompetitionId = 1,
                    HomeTeamId = 2,
                    AwayTeamId = 1,
                    StartDateAndTime = DateTime.Now.AddDays(6),
                    Status = 0,
                    GoalsAway = 0,
                    GoalsHome = 0

                });

        }
    }
}
