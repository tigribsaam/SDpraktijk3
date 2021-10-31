using System;
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
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public DateTime StartDateAndTime { get; set; }
        public int GoalsHome { get; set; }
        public int GoalsAway { get; set; }
        // 0 not started yet, 1 started, 2 finished
        public int Status { get; set; }
    }
}
