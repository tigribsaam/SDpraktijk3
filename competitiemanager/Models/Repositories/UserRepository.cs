using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbConext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }

        public IEnumerable<User> AllUsers =>
            new List<User>
            {
                new User {
                    UserId = 1,
                    Name = "Ad Random",
                    TotoScore = 0,
                    Bets = new List<Bet>{}}
            };

        public User GetUserById(int userId)
        {
            return AllUsers.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
