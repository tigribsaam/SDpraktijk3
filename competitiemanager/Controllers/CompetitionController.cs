using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly ICompetitionRepository _competitionRepository;
        private readonly ITeamRepository _teamRepository;

        public CompetitionController(ICompetitionRepository competitionRepository, ITeamRepository teamRepository)
        {
            _competitionRepository = competitionRepository;
            _teamRepository = teamRepository;
        }

        public ViewResult List()
        {
            CompetitionListViewModel CompListViewModel = new CompetitionListViewModel();
            CompListViewModel.Competition = _competitionRepository.AllCompetitions;
            CompListViewModel.Team = _teamRepository.AllTeams;
            return View(CompListViewModel);
        }
    }
}
