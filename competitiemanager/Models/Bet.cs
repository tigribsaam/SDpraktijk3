using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Bet
    {
        public int BetId { get; set; }
        public Game Game { get; set; }
        public String Prediction { get; set; }
    }
}
