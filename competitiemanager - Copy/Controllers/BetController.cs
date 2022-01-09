using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace competitiemanager.Controllers
{
    public class BetController : Controller
    {
        private readonly IBetRepository _betRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IUserRepository _userRepository;
        private string _userId;



        public BetController(IBetRepository betRepository, IGameRepository gameRepository, IUserRepository userRepositroy, IHttpContextAccessor httpContextAccessor)
        {
            _betRepository = betRepository;
            _gameRepository = gameRepository;
            _userRepository = userRepositroy;
            _userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public ViewResult Index()
        {
            BetListViewModel betListViewModel = new BetListViewModel();
            betListViewModel.Bets = _betRepository.AllBets;
            return View(betListViewModel);
        }



        //TODO: maar 1 bet pp ook hier op dubbelen checken
        [Authorize]
        public ActionResult PlaceBet(int id)
        {

            var game = _gameRepository.GetGameById(id);
            var betsPlaced = _betRepository.AllBets.Where(g => g.GameId == id);
            var UserPlacedBet = betsPlaced.Where(u => u.User.IdentityId == _userId);

            //geen weddenschap plaatsen als: de wedstrijdbegonnen is (status of starttijd) of al een weddenschap heeft geplaatst
            if (game.Status >= 2 || game.StartDateAndTime < DateTime.Now || UserPlacedBet.Count() != 0)
            {
                return RedirectToAction("Details", "Game", new { id = id });
            }
            BetFormViewModel model = new BetFormViewModel { game = _gameRepository.GetGameById(id) };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult PlaceBet(BetFormViewModel model)
        {
            model.game = _gameRepository.GetGameById(model.GameId);
            model.User = _userRepository.GetUserById(_userId);

            var betsPlaced = _betRepository.AllBets.Where(g => g.GameId == model.GameId);
            var UserPlacedBet = betsPlaced.Where(u => u.User.IdentityId == _userId);

            if (ModelState.IsValid && model.game.Status < 2 && UserPlacedBet.Count() == 0)
            {
                _betRepository.PlaceBet(model);
                return RedirectToAction("Details", "Game", new { id = model.GameId });
            }
            model.game = _gameRepository.GetGameById(model.GameId);
            return View(model);
        }
    }
}
