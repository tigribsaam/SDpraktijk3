using competitiemanager.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<User> AllUsers
        {
            get
            {
                return _appDbConext.UsersToto.Include(b => b.Bets);
            }
        }


    public User GetUserById(int userId)
        {
            return AllUsers.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
