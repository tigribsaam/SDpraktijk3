using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{

    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> AllUsers => throw new NotImplementedException();

        public User GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
