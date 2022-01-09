using competitiemanager.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
        public class HomeModel
        {
        [CustomValidation(typeof(Competition), "TestLengthTeams1")]
        public IList<string> SelectedFruits { get; set; }

        
        public IList<SelectListItem> AvailableFruits { get; set; }

            public HomeModel()
            {
                SelectedFruits = new List<string>();
                AvailableFruits = new List<SelectListItem>();
            }
        }
   


}
