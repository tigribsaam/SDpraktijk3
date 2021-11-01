using competitiemanager.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _appDbConext;

        public GameRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }

        public IEnumerable<Game> AllGames
        {
            get
            {
                return _appDbConext.Games.Include(t => t.HomeTeam).ThenInclude(t => t.Team).Include(t => t.AwayTeam).ThenInclude(t => t.Team);
            }
        }

        public Game GetGameById(int gameId)
        {
            return AllGames.FirstOrDefault(g => g.GameId == gameId);
        }
    }
}
