using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using competitiemanager.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace competitiemanager.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public IActionResult Index()
        {
            var users = _userRepository.AllUsers.ToList();
            //sort - based on totoscore
            users.Sort((a, b) => b.TotoScore.CompareTo(a.TotoScore));
            ViewBag.users = users;

            return View();
        }
    }
}
