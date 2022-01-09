using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class TeamInCompetition
    {
        public int TeamInCompetitionId { get; set; }
        public int TeamId { get; set; }
        public int CompetitionId { get; set; }
        public Team Team { get; set; }
        public Competition Competition { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int GamesTied { get; set; }
        public int Goals { get; set; }
        public int CounterGoals { get; set; }
        public int Points { get; set; }
        public int DoelSaldo { get; set; }

    }
}
