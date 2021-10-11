using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly IGameRepository _gameRepository = new GameRepository();
        public Game GetGameById(int GameId)
        {
            throw new NotImplementedException();
        }
    }
}
