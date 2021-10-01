using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public IEnumerable<Team> AllTeams => throw new NotImplementedException();

        public Team GetTeamById(int TeamId)
        {
            throw new NotImplementedException();
        }
    }
}
