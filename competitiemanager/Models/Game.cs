using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public DateTime StartDateAndTime { get; set; }
        public int GoalsHome { get; set; }
        public int GoalsAway { get; set; }
    }
}
