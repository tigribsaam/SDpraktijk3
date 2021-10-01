using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class TeamInCompetition
    {
        public Team Team { get; set; }
        public Competition Competition { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int GamesPlayedDraw { get; set; }
        public int Goals { get; set; }
        public int CounterGoals { get; set; }

    }
}
