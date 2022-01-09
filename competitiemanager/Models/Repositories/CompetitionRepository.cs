using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using competitiemanager.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class CompetitionRepository : ICompetitionRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ITeamRepository _teamRepository;

        public CompetitionRepository(AppDbContext appDbContext, ITeamRepository teamRepository)
        {
            _appDbContext = appDbContext;
            _teamRepository = teamRepository;
        }

        public IEnumerable<Competition> AllCompetitions
        {
            get
            {
                return _appDbContext.Competitions.Include(t => t.Teams).ThenInclude(t => t.Team).Include(g => g.Games);
            }
        }


        public Competition GetCompById(int compId)
        {
            return AllCompetitions.FirstOrDefault(c => c.CompetitionId == compId);
        }




        public void CreateComp(NewCompViewModel model)
        {
            //create competition
            Competition newComp = new Competition
            {
                Name = model.Name,
                Teams = new List<TeamInCompetition>(),
                Games = new List<Game>()
            };
            _appDbContext.Competitions.Add(newComp);
            _appDbContext.SaveChanges();


            //create teams in competition
            List<int> teamsinComp = new List<int>();
            foreach (var teamId in model.SelectedTeam)
            {
                TeamInCompetition t = new TeamInCompetition {
                    
                    TeamId = teamId,
                    CompetitionId = newComp.CompetitionId,
                    GamesPlayed = 0,
                    GamesWon = 0,
                    GamesLost = 0,
                    GamesTied = 0,
                    Goals = 0,
                    CounterGoals = 0,
                    Points = 0,
                    DoelSaldo = 0
                };
                _appDbContext.TeamInComps.Add(t);
                _appDbContext.SaveChanges();
                teamsinComp.Add(t.TeamInCompetitionId);
            }


            //rekencijfers:

            List<string> teams = teamsinComp.ConvertAll(delegate (int i) { return i.ToString(); });
            //add 'break' if odd numbers 
            if ((teams.Count % 2) != 0)
            {
                teams.Add("break");
            }
            List<string> reversedTeams = new List<string>(teams);
            reversedTeams.Reverse();

            //next Saturday as start day, unless today is Saturday
            DateTime today = DateTime.Today.AddHours(12);
            int daysUntilSaturday = (((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7) + 1;
            DateTime gameday = today.AddDays(daysUntilSaturday);

            var r = new Random();

            //definition double round robin: total home and away games, max games per week, duration of competition 
            int NumGames = teams.Count * (teams.Count - 1);
            int NumPerWeek = (teams.Count / 2);
            int NumWeeks = NumGames / NumPerWeek;

           


            // (double) round robin 
            //loop per weeks
            for (int i = 0; i < NumWeeks; i++)
            {
                //loop of games per week
                for (int k = 0; k< NumPerWeek; k++)
                {
                    //continues if team goes against 'break'
                    if(teams[k].Equals("break") || reversedTeams[k].Equals("break"))
                    {
                        continue;
                    }

                    Game g = new Game
                    {
                        CompetitionId = newComp.CompetitionId,
                        HomeTeamId = int.Parse(teams[k]),              
                        AwayTeamId = int.Parse(reversedTeams[k]),     
                        StartDateAndTime = gameday.AddDays(7*i).AddHours(r.Next(0, 9)),        
                        Status = 0

                    };
                    System.Diagnostics.Debug.WriteLine(g.StartDateAndTime);
                    _appDbContext.Games.Add(g); 

                }


                //round robin logica: teams move a place in the list except for one
                //for double round robin switch lists
                if (i == (NumWeeks / 2) - 1)
                {
                    var templist = teams;
                    teams = new List<string>(reversedTeams);
                    reversedTeams = new List<string>(templist);
                }
                if (i >= (NumWeeks / 2) - 1)
                {
                    string temp = reversedTeams[1];
                    reversedTeams.RemoveAt(1);
                    reversedTeams.Add(temp);

                    teams = new List<string>(reversedTeams);
                    teams.Reverse();
                }
                else
                {
                    string temp = teams[1];
                    teams.RemoveAt(1);
                    teams.Add(temp);

                    reversedTeams = new List<string>(teams);
                    reversedTeams.Reverse();
                }
                

            }
            _appDbContext.SaveChanges();


        }
    }
}
