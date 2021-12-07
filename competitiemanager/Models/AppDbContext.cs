
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
            //var splitStringConverter = new ValueConverter<IEnumerable<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            //modelBuilder.Entity<Team>().Property(nameof(Team.Players)).HasConversion(splitStringConverter);

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
                new Player { PlayerId = 3, Name = "speler 3" , TeamId = 1},
                new Player { PlayerId = 4, Name = "speler 4" , TeamId = 1},
                new Player { PlayerId = 5, Name = "speler 5" , TeamId = 1},
                new Player { PlayerId = 6, Name = "speler 6" , TeamId = 1},
                new Player { PlayerId = 7, Name = "speler 7" , TeamId = 2},
                new Player { PlayerId = 8, Name = "speler 8" , TeamId = 2},
                new Player { PlayerId = 9, Name = "speler 9" , TeamId = 2},
                new Player { PlayerId = 10, Name = "speler 10" , TeamId = 2},
                new Player { PlayerId = 11, Name = "speler 11" , TeamId = 2},
                new Player { PlayerId = 12, Name = "speler 12" , TeamId = 2}
                );


            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        UserId = 1,
            //        Name = "Ad Random",
            //        TotoScore = 0,
            //        Bets = null
            //    });

            modelBuilder.Entity<Competition>().HasData(
                new Competition
                {
                    CompetitionId = 1,
                    Name = "test competitie 1",
                    Teams = new List<TeamInCompetition>(),
                    Games = new List<Game>()
                },
                new Competition
                {
                    CompetitionId = 2,
                    Name = "test competitie 2",
                    Teams = new List<TeamInCompetition>(),
                    Games = new List<Game>()
                });

            modelBuilder.Entity<TeamInCompetition>().HasData(
                new TeamInCompetition
                {
                    TeamInCompetitionId = 1,
                    TeamId = 1,
                    CompetitionId = 1,
                    GamesPlayed = 0,
                    GamesWon = 0,
                    GamesLost = 0,
                    GamesTied = 0,
                    Goals = 0,
                    CounterGoals = 0,
                    Points = 0,
                    DoelSaldo = 0
                },
                new TeamInCompetition
                {
                    TeamInCompetitionId = 2,
                    TeamId = 2,
                    CompetitionId = 1,
                    GamesPlayed = 0,
                    GamesWon = 0,
                    GamesLost = 0,
                    GamesTied = 0,
                    Goals = 0,
                    CounterGoals = 0,
                    Points = 0,
                    DoelSaldo = 0
                }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    CompetitionId = 1,
                    HomeTeamId = 1,
                    AwayTeamId = 2,
                    StartDateAndTime = DateTime.Now,
                    Status = 0

                },
                new Game
                {
                    GameId = 2,
                    CompetitionId = 1,
                    HomeTeamId = 2,
                    AwayTeamId = 1,
                    StartDateAndTime = DateTime.Now,
                    Status = 0

                },
                new Game
                {
                    GameId = 3,
                    CompetitionId = 2,
                    HomeTeamId = 2,
                    AwayTeamId = 1,
                    StartDateAndTime = DateTime.Now,
                    Status = 3,
                    GoalsHome = 0,
                    GoalsAway = 3

                });

        }
    }
}
