using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    public interface IGameRepository
    {
        IEnumerable<Game> AllGames { get; }
        Game GetGameById(int gameId);
    }
}
