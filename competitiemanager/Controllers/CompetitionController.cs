﻿using System;
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
            CompListViewModel.Competition = _competitionRepository.AllCompetitions;
            CompListViewModel.Team = _teamRepository.AllTeams;
            return View(CompListViewModel);
        }

        public ActionResult Details(int id)
        {
            var comp = _competitionRepository.GetCompById(id);
            if (comp == null)
                return NotFound();

            //foreach (var teamInComp in _teamInCompRepository.AllTeamsInComp)
            //{
            //    if (teamInComp.CompetitionId == id)
            //    {
            //        comp.Teams.Add(teamInComp);
            //        System.Diagnostics.Debug.WriteLine(teamInComp);
            //    }
            //}

            return View(comp);

        }
    }
}
