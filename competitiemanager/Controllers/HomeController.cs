using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly IGameRepository _gameRepository;

        public HomeController(IGameRepository gameRepository, IUserRepository userRepository)
        {
            _gameRepository = gameRepository;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            //games of this week
            var today = DateTime.Today;
            var range = DateTime.Today.AddDays(6);

            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Games = _gameRepository.AllGames.Where(d => d.StartDateAndTime >= today && d.StartDateAndTime < range);

            var users = _userRepository.AllUsers.ToList();
            //sort - based on totoscore
            users.Sort((a, b) => b.TotoScore.CompareTo(a.TotoScore));
            homeViewModel.Users = users.Take(25);

            return View(homeViewModel);
        }
    }
}
