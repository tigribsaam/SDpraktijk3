using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IBetRepository _betRepository;
        private readonly IUserRepository _userRepository;
        private string _userId;

        public GameController(IGameRepository gameRepository, IBetRepository betRepository, IUserRepository userRepositroy, IHttpContextAccessor httpContextAccessor)
        {
            _gameRepository = gameRepository;
            _betRepository = betRepository;
            _userRepository = userRepositroy;
            _userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
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

            GameDetailsViewModel ViewModel = new GameDetailsViewModel();
            ViewModel.game = Game;
            ViewModel.bets = _betRepository.AllBets.Where(g => g.GameId == id);
            ViewModel.currentUser = _userId;
            ViewModel.placedBet = ViewModel.bets.FirstOrDefault(u => u.User.IdentityId == _userId);
            return View(ViewModel);

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
