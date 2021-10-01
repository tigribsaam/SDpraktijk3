using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class CompetitionRepository : ICompetitionRepository
    {
        public IEnumerable<Competition> AllCompetitions => throw new NotImplementedException();

        public Competition GetCompById(int CompId)
        {
            throw new NotImplementedException();
        }
    }
}
