﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using competitiemanager.Models;

namespace competitiemanager.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211101091138_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("competitiemanager.Models.Bet", b =>
                {
                    b.Property<int>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Prediction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BetId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("competitiemanager.Models.Competition", b =>
                {
                    b.Property<int>("CompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompetitionId");

                    b.ToTable("Competitions");

                    b.HasData(
                        new
                        {
                            CompetitionId = 1,
                            Name = "test competitie 1"
                        },
                        new
                        {
                            CompetitionId = 2,
                            Name = "test competitie 2"
                        });
                });

            modelBuilder.Entity("competitiemanager.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("GoalsAway")
                        .HasColumnType("int");

                    b.Property<int>("GoalsHome")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            AwayTeamId = 2,
                            CompetitionId = 1,
                            GoalsAway = 0,
                            GoalsHome = 0,
                            HomeTeamId = 1,
                            StartDateAndTime = new DateTime(2021, 11, 1, 10, 11, 37, 183, DateTimeKind.Local).AddTicks(7177),
                            Status = 0
                        },
                        new
                        {
                            GameId = 2,
                            AwayTeamId = 1,
                            CompetitionId = 1,
                            GoalsAway = 0,
                            GoalsHome = 0,
                            HomeTeamId = 2,
                            StartDateAndTime = new DateTime(2021, 11, 1, 10, 11, 37, 189, DateTimeKind.Local).AddTicks(4274),
                            Status = 0
                        },
                        new
                        {
                            GameId = 3,
                            AwayTeamId = 1,
                            CompetitionId = 2,
                            GoalsAway = 3,
                            GoalsHome = 0,
                            HomeTeamId = 2,
                            StartDateAndTime = new DateTime(2021, 11, 1, 10, 11, 37, 189, DateTimeKind.Local).AddTicks(4369),
                            Status = 3
                        });
                });

            modelBuilder.Entity("competitiemanager.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            Name = "speler 1",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 2,
                            Name = "speler 2",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 3,
                            Name = "speler 3",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 4,
                            Name = "speler 4",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 5,
                            Name = "speler 5",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 6,
                            Name = "speler 6",
                            TeamId = 1
                        },
                        new
                        {
                            PlayerId = 7,
                            Name = "speler 7",
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 8,
                            Name = "speler 8",
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 9,
                            Name = "speler 9",
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 10,
                            Name = "speler 10",
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 11,
                            Name = "speler 11",
                            TeamId = 2
                        },
                        new
                        {
                            PlayerId = 12,
                            Name = "speler 12",
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("competitiemanager.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Location = "locatie A",
                            Name = "De Winnaars"
                        },
                        new
                        {
                            TeamId = 2,
                            Location = "locatie B",
                            Name = "De Verliezers"
                        });
                });

            modelBuilder.Entity("competitiemanager.Models.TeamInCompetition", b =>
                {
                    b.Property<int>("TeamInCompetitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("CounterGoals")
                        .HasColumnType("int");

                    b.Property<int>("GamesLost")
                        .HasColumnType("int");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("GamesTied")
                        .HasColumnType("int");

                    b.Property<int>("GamesWon")
                        .HasColumnType("int");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("TeamInCompetitionId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamInComps");

                    b.HasData(
                        new
                        {
                            TeamInCompetitionId = 1,
                            CompetitionId = 1,
                            CounterGoals = 0,
                            GamesLost = 0,
                            GamesPlayed = 0,
                            GamesTied = 0,
                            GamesWon = 0,
                            Goals = 0,
                            TeamId = 1
                        },
                        new
                        {
                            TeamInCompetitionId = 2,
                            CompetitionId = 1,
                            CounterGoals = 0,
                            GamesLost = 0,
                            GamesPlayed = 0,
                            GamesTied = 0,
                            GamesWon = 0,
                            Goals = 0,
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("competitiemanager.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotoScore")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "Ad Random",
                            TotoScore = 0
                        });
                });

            modelBuilder.Entity("competitiemanager.Models.Bet", b =>
                {
                    b.HasOne("competitiemanager.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("competitiemanager.Models.User", null)
                        .WithMany("Bets")
                        .HasForeignKey("UserId");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("competitiemanager.Models.Game", b =>
                {
                    b.HasOne("competitiemanager.Models.TeamInCompetition", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("competitiemanager.Models.Competition", null)
                        .WithMany("Games")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("competitiemanager.Models.TeamInCompetition", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("competitiemanager.Models.Player", b =>
                {
                    b.HasOne("competitiemanager.Models.Team", null)
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("competitiemanager.Models.TeamInCompetition", b =>
                {
                    b.HasOne("competitiemanager.Models.Competition", "Competition")
                        .WithMany("Teams")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("competitiemanager.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("competitiemanager.Models.Competition", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("competitiemanager.Models.Team", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("competitiemanager.Models.User", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}