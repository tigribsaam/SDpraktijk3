using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String Name { get; set; }
        //????????? role?????
        public String Role { get; set; }
        public int TotoScore { get; set; }
        public List<Bet> Bets { get; set; }
    }
}
