using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
