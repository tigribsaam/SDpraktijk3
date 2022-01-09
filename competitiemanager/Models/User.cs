using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string IdentityId { get; set; }
        public String Name { get; set; }
        public String Role { get; set; }
        public int TotoScore { get; set; }
        public List<Bet> Bets { get; set; }
    }
}
