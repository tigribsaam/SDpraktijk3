using competitiemanager.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<TeamInCompetition> AllTeamsInComp
        {
            get
            {
                return _appDbConext.TeamInComps.Include(t => t.Team).ThenInclude(p => p.Players).Include(c => c.Competition);
            }
        }

        public TeamInCompetition GetTeamInCompById(int teamInCompId)
        {
            return AllTeamsInComp.FirstOrDefault(t => t.TeamInCompetitionId == teamInCompId);
        }
    }
    
}
