using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
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
            return View(_teamRepository.AllTeams);
        }
    }
}
