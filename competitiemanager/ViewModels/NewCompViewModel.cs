using competitiemanager.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class NewCompViewModel
    {
        
        [Required(ErrorMessage = "Voer de naam van de competitie in")]
        [Display(Name = "Naam")]
        [StringLength(50)]
        public String Name { get; set; }


        //[CustomValidation(typeof (MyClassWhereMethodIsLocated), "MyStaticMethodName")],https://stackoverflow.com/questions/22357571/how-can-i-validate-a-list-array-count-in-an-mvc-model-using-data-annotations
        [CustomValidation(typeof(Competition), "TestLengthTeams")]
        [Display(Name = "Teams")]
        public IList<int> SelectedTeam { get; set; }

        public NewCompViewModel()
        {
            SelectedTeam = new List<int>();
            
        }




    }
}
