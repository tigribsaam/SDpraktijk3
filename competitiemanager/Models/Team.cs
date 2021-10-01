using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public String Name { get; set; }
        public List<String> Players { get; set; }
        public String Location { get; set; }
    }
}
