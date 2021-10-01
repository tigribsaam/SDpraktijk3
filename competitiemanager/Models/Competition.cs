using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Competition
    {
        public int CompId { get; set; }
        public String Name { get; set; }
        public List<TeamInCompetition> Teams { get; set; }
        public List<Game> Games { get; set; }
    }
}
