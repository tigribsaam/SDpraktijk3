using competitiemanager.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _appDbConext;

        public TeamRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }

        public IEnumerable<Team> AllTeams
        {
            get
            {
                return _appDbConext.Teams.Include(p => p.Players);
            }
        }

        public Team GetTeamById(int teamId)
        {
            return AllTeams.FirstOrDefault(t => t.TeamId == teamId);
        }
    }
}
