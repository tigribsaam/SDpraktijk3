using competitiemanager.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class CompetitionRepository : ICompetitionRepository
    {
        private readonly AppDbContext _appDbConext;

        public CompetitionRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }
        public IEnumerable<Competition> AllCompetitions
        {
            get
            {
                var comps = _appDbConext.Competitions.Include(t => t.Teams).Include(g => g.Games);

                //insert team objects into Teams

                //foreach (var comp in comps)
                //{
                //    foreach (var team in Teams)
                //    comp.Teams = 
                //}
                return comps;
            }
        }

        public Competition GetCompById(int CompId)
        {
            throw new NotImplementedException();
        }
    }
}
