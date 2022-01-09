using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Team
    {
        [Key, BindNever]
        public int TeamId { get; set; }

        [Required(ErrorMessage = "Voer de naam van het team in")]
        [Display(Name = "Naam")]
        [StringLength(50)]
        public String Name { get; set; }
        [BindNever]
        public List<Player> Players { get; set; }
        [Required(ErrorMessage = "Voer de thuislocatie van het team in")]
        [Display(Name = "Locatie")]
        [StringLength(50)]
        public String Location { get; set; }




        public static ValidationResult TestLengthPlayers(List<String> Teams, ValidationContext pValidationContext)
        {
            Teams.RemoveAll(item => item == null);
            if (Teams == null || Teams.Count < 2 || Teams.Count > 20) // cannot start with a digit
                return new ValidationResult("Voeg minimaal 2 en maximaal 20 spelers toe aan het team", new List<string> { "CategoryName" });
            return ValidationResult.Success;
        }

    }
}
