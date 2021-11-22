using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class GameFormViewModel
    {
        public Game game { get; set; }
        public int GameId { get; set; }

        [Required(ErrorMessage = "Voer het aantal doelpunten in")]
        [Display(Name = "Doelpunten thuis")]
        [Range(0, 1000, ErrorMessage = "Voer geen negatieve waarden in")]
        public int GoalsHome { get; set; }
        [Required(ErrorMessage = "Voer het aantal doelpunten in")]
        [Display(Name = "Doelpunten uit")]
        [Range(0, 1000, ErrorMessage = "Voer geen negatieve waarden in")]
        public int GoalsAway { get; set; }
        public Competition comp { get; set; }


        public GameFormViewModel()
        {
            this.game = new Game();
        }
    }
}
