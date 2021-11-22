﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public ViewResult List()
        {

            GameViewModel GameViewModel = new GameViewModel();
            GameViewModel.Game = _gameRepository.AllGames;
            return View(GameViewModel);
        }

        public ActionResult Details(int id)
        {
            
            var Game = _gameRepository.GetGameById(id);
            if (Game == null)
                return NotFound();
            return View(Game);

        }

        public ActionResult inputscore(int id)
        {
            if(_gameRepository.GetGameById(id).Status == 3)
            {
                return RedirectToAction("Details", new { id = id });
            }
            GameFormViewModel model = new GameFormViewModel {game = _gameRepository.GetGameById(id)};

            return View(model);
        }

        [HttpPost]
        public ActionResult inputscore(GameFormViewModel model)
        {
            //check of de wedstrijd al is afgelopen
            if (ModelState.IsValid && _gameRepository.GetGameById(model.GameId).Status<3)
            {
                _gameRepository.updateGame(model);
               
                return RedirectToAction("Details", new { id = model.GameId});
            }
            model.game = _gameRepository.GetGameById(model.GameId);
            return View(model);
        }
    }
}
