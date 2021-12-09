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
            ViewBag.users = _userRepository.AllUsers;
            return View();
        }
    }
}
