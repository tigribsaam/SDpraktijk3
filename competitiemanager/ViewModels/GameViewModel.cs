using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class GameViewModel
    {
        public IEnumerable<Game> Game { get; set; }
    }
}
