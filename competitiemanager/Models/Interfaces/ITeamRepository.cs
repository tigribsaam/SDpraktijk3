using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    public interface ITeamRepository
    {
        IEnumerable<Team> AllTeams { get; }
        Team GetTeamById(int teamId);
        
    }
}
