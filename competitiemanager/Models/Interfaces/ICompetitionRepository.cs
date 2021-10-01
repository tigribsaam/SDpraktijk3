using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    public interface ICompetitionRepository
    {
        IEnumerable<Competition> AllCompetitions {get;}
        Competition GetCompById(int CompId);
    }
}
