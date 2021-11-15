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
                var comps = _appDbContext.Competitions.Include(t => t.Teams).ThenInclude(t => t.Team).Include(g => g.Games);
                return comps;
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
            //List<TeamInCompetition> TeamsInComp = new List<TeamInCompetition>();  --niet meer nodig--
            foreach (var teamId in model.SelectedTeam)
            {
                _appDbContext.TeamInComps.Add(new TeamInCompetition {
                    
                    TeamId = teamId,
                    CompetitionId = newComp.CompetitionId,
                    GamesPlayed = 0,
                    GamesWon = 0,
                    GamesLost = 0,
                    GamesTied = 0,
                    Goals = 0,
                    CounterGoals = 0
                });   
            }
            _appDbContext.SaveChanges();

            //definitie voor hele competitie: uit- en thuiswedstrijden, max wedstrijden per week als elk team max 1x per week speelt
            int AantalWedstrijden = model.SelectedTeam.Count * (model.SelectedTeam.Count - 1);
            int AantalPerWeek = (model.SelectedTeam.Count / 2);
            int AantalWeken = AantalWedstrijden / AantalPerWeek;

            //rekencijfers 
            var blabla = 0;

            //create games in competition
            foreach (var teamId in model.SelectedTeam)
            {
                









                new Game
                {
                    CompetitionId = newComp.CompetitionId,
                    HomeTeamId = 0,                  //????,
                    AwayTeamId = 0,                  //????,
                    StartDateAndTime = DateTime.Now,            //DateTime.Now,
                    Status = 0

                };
            }



            //_appDbContext.Competition.Add(???);
            //_appDbContext.SaveChanges();

        }
    }
}
