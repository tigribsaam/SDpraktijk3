using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamRepository _teamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public ViewResult List()
        {
            TeamViewModel teamViewModel = new TeamViewModel();
            teamViewModel.Team = _teamRepository.AllTeams;
            return View(teamViewModel);
        }
        
        public ActionResult Details(int id)
        {
            var team = _teamRepository.GetTeamById(id);
            if (team == null)
                return NotFound();
            return View(team);

        }

        [Authorize]
        public IActionResult NewTeam()
        {
            var model = new NewTeamViewModel { };
            return View(model);
        }

        [HttpPost]
        public IActionResult NewTeam(NewTeamViewModel model)
        {
            model.Players.RemoveAll(item => item == null);

            if (ModelState.IsValid)
            {
                _teamRepository.CreateTeam(model);
                return RedirectToAction("List");
            }
            return View(model);
        }
    }
}
