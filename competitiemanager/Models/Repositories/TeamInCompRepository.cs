using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class TeamInCompRepository : ITeamInCompRepository
    {
        private readonly AppDbContext _appDbConext;

        public TeamInCompRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }

        public TeamInCompetition GetTeamInCompById(int TeamId)
        {
            throw new NotImplementedException();
        }
    }
}
