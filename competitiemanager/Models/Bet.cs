using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Bet
    {
        [Key]
        public int BetId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public String Prediction { get; set; }
    }
}
