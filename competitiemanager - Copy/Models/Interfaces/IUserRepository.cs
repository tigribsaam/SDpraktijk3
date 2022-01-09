using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }
        User GetUserById(int userId);
        User GetUserById(string userId);
    }
}
