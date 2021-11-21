using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ITeamInCompRepository _teamInCompRepository;

        public GameRepository(AppDbContext appDbContext, ITeamInCompRepository teamInCompetition)
        {
            _appDbContext = appDbContext;
            _teamInCompRepository = teamInCompetition;
        }

        public IEnumerable<Game> AllGames
        {
            get
            {
                return _appDbContext.Games.Include(t => t.HomeTeam).ThenInclude(t => t.Team).Include(t => t.AwayTeam).ThenInclude(t => t.Team);
            }
        }

        public Game GetGameById(int gameId)
        {
            return AllGames.FirstOrDefault(g => g.GameId == gameId);
        }

        public void updateGame(GameFormViewModel model)
        {
            //TODO:
            //- bets object update
            //- User object update??

            Game theGame = GetGameById(model.GameId);

            theGame.GoalsHome = model.GoalsHome;
            theGame.GoalsAway = model.GoalsAway;
            theGame.Status = model.game.Status;

            
            if(model.game.Status == 3)
            {
                //bets
                //users

                //teamsincomp
                TeamInCompetition HomeTeam = _teamInCompRepository.GetTeamInCompById(theGame.HomeTeamId);
                TeamInCompetition AwayTeam = _teamInCompRepository.GetTeamInCompById(theGame.AwayTeamId);

                //doelsaldo
                HomeTeam.Goals = HomeTeam.Goals + model.GoalsHome;
                HomeTeam.CounterGoals = HomeTeam.CounterGoals + model.GoalsAway;
                AwayTeam.Goals = AwayTeam.Goals + model.GoalsAway;
                AwayTeam.CounterGoals = AwayTeam.CounterGoals + model.GoalsHome;

                //uitslag
                if (theGame.GoalsHome == theGame.GoalsAway)
                {
                    HomeTeam.GamesTied += 1; // HomeTeam.GamesTied++;
                    AwayTeam.GamesTied += 1; // AwayTeam.GamesTied++;
                }
                if (theGame.GoalsHome > theGame.GoalsAway)
                {
                    HomeTeam.GamesWon += 1; // HomeTeam.GamesWon++;
                    AwayTeam.GamesLost += 1; //= AwayTeam.GamesLost++;
                }
                else
                {
                    AwayTeam.GamesWon += 1; //= AwayTeam.GamesWon++;
                    HomeTeam.GamesLost += 1; //= HomeTeam.GamesLost++;
                }






            }
            else
            {
                //als de wedstrijd nog bezig is
            }






            _appDbContext.SaveChanges();

        }
    }
}
