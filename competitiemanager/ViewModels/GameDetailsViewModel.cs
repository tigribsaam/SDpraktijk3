using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class GameDetailsViewModel
    {
        public Game game { get; set; }
        public IEnumerable<Bet> bets { get; set; } = new List<Bet>();
        public String currentUser { get; set; } = "";

    }
}
