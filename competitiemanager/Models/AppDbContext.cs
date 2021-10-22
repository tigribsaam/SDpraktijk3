using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<TeamInCompetition> TeamInComps { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<User> Users { get; set; }
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


            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Name = "Ad Random",
                    TotoScore = 0,
                    Bets = null
                });
        }
    }
}
