﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public int CompetitionId { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public TeamInCompetition HomeTeam { get; set; }
        public TeamInCompetition AwayTeam { get; set; }
        public DateTime StartDateAndTime { get; set; }
        [Required(ErrorMessage = "Voer het aantal doelpunten in")]
        [Display(Name = "Doelpunten thuis")]
        public int GoalsHome { get; set; }
        [Required(ErrorMessage = "Voer het aantal doelpunten in")]
        [Display(Name = "Doelpunten uit")]
        public int GoalsAway { get; set; }
        // 0 not started yet, 2 started, 3 finished
        public int Status { get; set; }
    }
}
