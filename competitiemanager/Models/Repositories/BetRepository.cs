
using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class BetRepository : IBetRepository
    {
        private readonly AppDbContext _appDbContext;

        public BetRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Bet> AllBets
        {
            get
            {
                return _appDbContext.Bets.Include(g => g.Game).Include(u => u.User);
            }          
        }

        public Bet GetBetById(int BetId)
        {
            return AllBets.FirstOrDefault(b => b.BetId == BetId);
        }

        public void PlaceBet(BetFormViewModel model)
        {
            Bet newBet = new Bet
            {
                GameId = model.GameId,
                UserId = model.User.UserId,
                Game = model.game,
                User = model.User,
                //1/1 = home 2/2 = away 3/x = tie
                Prediction = model.Prediction
            };
            _appDbContext.Bets.Add(newBet);
            _appDbContext.SaveChanges();
    
        }
    }
}
