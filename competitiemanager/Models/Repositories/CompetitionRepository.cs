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

            List<int> teamsinComp = new List<int>();
            //create teams in competition
            //List<TeamInCompetition> TeamsInComp = new List<TeamInCompetition>();  --niet meer nodig--
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
                    CounterGoals = 0
                };
                _appDbContext.TeamInComps.Add(t);
                _appDbContext.SaveChanges();
                teamsinComp.Add(t.TeamInCompetitionId);
            }


            //rekencijfers:

            List<string> teams = teamsinComp.ConvertAll(delegate (int i) { return i.ToString(); });
            //bij oneven aantallen 'rust' toevoegen 
            if ((teams.Count % 2) != 0)
            {
                teams.Add("break");
            }
            List<string> reversedTeams = new List<string>(teams);
            reversedTeams.Reverse();

            //eerst volgende zaterdag als startdag, tenzij vandaag zaterdag is
            DateTime today = DateTime.Today.AddHours(12);
            int daysUntilSaturday = (((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7) + 1;
            DateTime gameday = today.AddDays(daysUntilSaturday);

            var r = new Random();

            //definitie voor hele competitie: uit- en thuiswedstrijden, max wedstrijden per week als elk team max 1x per week speelt
            int AantalWedstrijden = teams.Count * (teams.Count - 1);
            int AantalPerWeek = (teams.Count / 2);
            int AantalWeken = AantalWedstrijden / AantalPerWeek;

           


            // (double) round robbin 
            //aantal weken
            for (int i = 0; i < AantalWeken; i++)
            {
                //aantal wedstrijden
                for (int k = 0; k< AantalPerWeek; k++)
                {
                    //geen wedstijd aanmaken als team tegen 'rust moet
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


                //round robbin logica: teams in lijsten doorschuiven behalve één
                //lijsten omwisselen op de helft van de competitie
                if (i == (AantalWeken / 2) - 1)
                {
                    var templist = teams;
                    teams = new List<string>(reversedTeams);
                    reversedTeams = new List<string>(templist);
                }
                if (i >= (AantalWeken / 2) - 1)
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
