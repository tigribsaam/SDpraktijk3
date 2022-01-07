using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class NewTeamViewModel
    {
        [Required(ErrorMessage = "Voer de naam van het team in")]
        [Display(Name = "Naam")]
        [StringLength(50)]
        public String Name { get; set; }

        [CustomValidation(typeof(Team), "TestLengthPlayers")]
        public List<String> Players { get; set; }

        [Required(ErrorMessage = "Voer de thuislocatie van het team in")]
        [Display(Name = "Locatie")]
        [StringLength(50)]
        public String Location { get; set; }

        public NewTeamViewModel()
        {
            Players = new List<String>();

        }
    }
}
