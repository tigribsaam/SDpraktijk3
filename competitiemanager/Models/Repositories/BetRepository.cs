
using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class BetRepository : IBetRepository
    {
        private readonly AppDbContext _appDbConext;

        public BetRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }
        
        public Bet GetBetById(int BetId)
        {
            throw new NotImplementedException();
        }
    }
}
