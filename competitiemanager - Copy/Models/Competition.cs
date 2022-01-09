using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Competition
    {
        [Key, BindNever]
        public int CompetitionId { get; set; }

        [Required(ErrorMessage = "Voer de naam van de competitie in")]
        [Display(Name = "Naam")]
        [StringLength(50)]
        public String Name { get; set; }
        [BindNever]
        public List<TeamInCompetition> Teams { get; set; }
        [BindNever]
        public List<Game> Games { get; set; }



        public static ValidationResult TestLengthTeams(List<int> Teams, ValidationContext pValidationContext)
        {
            if (Teams == null || Teams.Count < 2 || Teams.Count > 100) // cannot start with a digit
                return new ValidationResult("Minimaal 2 en maximaal 100 teams moeten meedoen aan de competitie", new List<string> { "CategoryName" });
            return ValidationResult.Success;
        }

    }
}
