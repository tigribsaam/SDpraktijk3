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
    public class BetController : Controller
    {
        private readonly IBetRepository _betRepository;
        private readonly IGameRepository _gameRepository;


        public BetController(IBetRepository betRepository, IGameRepository gameRepository)
        {
            _betRepository = betRepository;
            _gameRepository = gameRepository;
        }

        [Authorize]
        public ActionResult PlaceBet(int gameId)
        {

            var game = _gameRepository.GetGameById(gameId);

            if (game.Status == 2 || game.StartDateAndTime> DateTime.Now)
            {
                return RedirectToAction("Details", new { id = gameId });
            }
            BetFormViewModel model = new BetFormViewModel { game = _gameRepository.GetGameById(gameId) };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult PlaceBet(BetFormViewModel model)
        {

            //var Game = _gameRepository.GetGameById(gameId);
            //if (Game == null)
            //    return NotFound();
            //return View(Game);

            if (ModelState.IsValid && _gameRepository.GetGameById(model.GameId).Status < 3)
            {
                //_gameRepository.updateGame(model);

                return RedirectToAction("Details", new { id = model.GameId });
            }
            model.game = _gameRepository.GetGameById(model.GameId);
            return View(model);

        }
    }
}
