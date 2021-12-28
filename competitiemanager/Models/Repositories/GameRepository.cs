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
        private readonly IBetRepository _betRepository;
        private readonly IUserRepository _userRepository;

        public GameRepository(AppDbContext appDbContext, ITeamInCompRepository teamInCompetition, IBetRepository betRepository, IUserRepository userRepository)
        {
            _appDbContext = appDbContext;
            _teamInCompRepository = teamInCompetition;
            _betRepository = betRepository;
            _userRepository = userRepository;
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
            Game theGame = GetGameById(model.GameId);

            theGame.GoalsHome = model.GoalsHome;
            theGame.GoalsAway = model.GoalsAway;
            theGame.Status = model.game.Status;

            
            if(model.game.Status == 3)
            {
                //bets
                //alle bets van deze game
                IEnumerable<Bet> placedBets = _betRepository.AllBets.Where(g => g.GameId == theGame.GameId);

                //alle bets met goede voorspelling fliteren
                if (theGame.GoalsHome == theGame.GoalsAway) //gelijk
                {
                    placedBets = placedBets.Where(p => p.Prediction == 3);
                }
                if (theGame.GoalsHome > theGame.GoalsAway) //thuis
                {
                    placedBets = placedBets.Where(p => p.Prediction == 1);
                }
                else
                {
                    placedBets = placedBets.Where(p => p.Prediction == 2);
                }

                //users
                //users van gefilterde bets krijgen punten
                foreach (var bet in placedBets)
                {
                    var user = _userRepository.GetUserById(bet.UserId);
                    user.TotoScore += 5;
                }

                //teamsincomp
                TeamInCompetition HomeTeam = _teamInCompRepository.GetTeamInCompById(theGame.HomeTeamId);
                TeamInCompetition AwayTeam = _teamInCompRepository.GetTeamInCompById(theGame.AwayTeamId);

                //doelsaldo
                HomeTeam.Goals = HomeTeam.Goals + model.GoalsHome;
                HomeTeam.CounterGoals = HomeTeam.CounterGoals + model.GoalsAway;
                AwayTeam.Goals = AwayTeam.Goals + model.GoalsAway;
                AwayTeam.CounterGoals = AwayTeam.CounterGoals + model.GoalsHome;
                HomeTeam.DoelSaldo = HomeTeam.Goals - HomeTeam.CounterGoals;
                AwayTeam.DoelSaldo = AwayTeam.Goals - AwayTeam.CounterGoals;

                HomeTeam.GamesPlayed += 1; 
                AwayTeam.GamesPlayed += 1;

                //uitslag
                if (theGame.GoalsHome == theGame.GoalsAway)
                {
                    HomeTeam.GamesTied += 1; // HomeTeam.GamesTied++;
                    AwayTeam.GamesTied += 1; // AwayTeam.GamesTied++;
                    HomeTeam.Points += 1;
                    AwayTeam.Points += 1;
                }
                if (theGame.GoalsHome > theGame.GoalsAway)
                {
                    HomeTeam.GamesWon += 1;
                    HomeTeam.Points += 3;// HomeTeam.GamesWon++;
                    AwayTeam.GamesLost += 1; //= AwayTeam.GamesLost++;
                }
                else
                {
                    AwayTeam.GamesWon += 1;
                    AwayTeam.Points += 3;//= AwayTeam.GamesWon++;
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
