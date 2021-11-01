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
    }
}
