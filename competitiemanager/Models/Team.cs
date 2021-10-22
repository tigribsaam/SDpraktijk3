using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public String Name { get; set; }
        public List<Player> Players { get; set; }
        public String Location { get; set; }
    }
}
