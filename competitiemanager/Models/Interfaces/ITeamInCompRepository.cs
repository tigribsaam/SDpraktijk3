using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    public interface ITeamInCompRepository
    {
        TeamInCompetition GetTeamInCompById(int TeamId);
        
    }
}
