using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class TeamInCompController : Controller
    {
        private readonly ITeamInCompRepository _teamInCompRepository;

        public TeamInCompController(ITeamInCompRepository teamInCompRepository)
        {
            _teamInCompRepository = teamInCompRepository;
        }

        public ViewResult List()
        {
            TeamInCompViewModel teamInCompViewModel = new TeamInCompViewModel();
            teamInCompViewModel.Team = _teamInCompRepository.AllTeamsInComp;
            return View(teamInCompViewModel);
        }

        public ActionResult Details(int id)
        {
            var team = _teamInCompRepository.GetTeamInCompById(id);
            if (team == null)
                return NotFound();
            return View(team);

        }
    }
}
