using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class BetFormViewModel
    {
        public Game game { get; set; }
        public int GameId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        //1/1 = thuis 2/2 = uit 3/x = gelijk
        [Required(ErrorMessage = "Voer de voorspelling in")]
        [Display(Name = "voorspelling")]
        [Range(1, 3)]

        public int Prediction { get; set; }


    }
}
