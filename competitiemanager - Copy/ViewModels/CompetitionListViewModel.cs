using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class CompetitionListViewModel
    {
        public IEnumerable<Competition> Competition { get; set; }

        public IEnumerable<Team> Team { get; set; }
    }
}
