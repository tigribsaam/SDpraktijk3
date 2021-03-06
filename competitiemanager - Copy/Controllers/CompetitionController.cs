using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class CompetitionController : Controller
    {
        private readonly ICompetitionRepository _competitionRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ITeamInCompRepository _teamInCompRepository;

        public CompetitionController(ICompetitionRepository competitionRepository, ITeamRepository teamRepository, ITeamInCompRepository teamInCompRepository)
        {
            _competitionRepository = competitionRepository;
            _teamRepository = teamRepository;
            _teamInCompRepository = teamInCompRepository;
        }

        public ViewResult List()
        {
            CompetitionListViewModel CompListViewModel = new CompetitionListViewModel();
            CompListViewModel.Competition = _competitionRepository.AllCompetitions.Reverse();
            CompListViewModel.Team = _teamRepository.AllTeams;
            return View(CompListViewModel);
        }

        public IActionResult Details(int id)
        {
           
            var comp = _competitionRepository.GetCompById(id);
            if (comp == null)
                return NotFound();
            comp.Teams.Sort((a, b) => b.Points.CompareTo(a.Points));
            
            //comp.Games.Where(item => item.Status == 3);
            comp.Games.Sort((a, b) => a.StartDateAndTime.CompareTo(b.StartDateAndTime));
            var gamesplayed = new List<Game>(comp.Games.Where(item => item.Status == 3));
            comp.Games.RemoveAll(item => item.Status == 3);
            comp.Games.AddRange(gamesplayed);
            return View(comp);

        }

        [Authorize]
        public IActionResult NewComp()
        {
            var model = new NewCompViewModel { };
            ViewBag.Teams = _teamRepository.AllTeams;
            return View(model);
        }

        [HttpPost]
        public IActionResult NewComp(NewCompViewModel model)
        {
            ViewBag.Teams = _teamRepository.AllTeams;

            if (ModelState.IsValid)
            {
                _competitionRepository.CreateComp(model);
                return RedirectToAction("List");
            }
            return View(model);
        }
    }
}
