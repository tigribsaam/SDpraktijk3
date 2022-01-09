using competitiemanager.Models.Interfaces;
using competitiemanager.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _appDbContext;

        public TeamRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Team> AllTeams
        {
            get
            {
                return _appDbContext.Teams.Include(p => p.Players);
            }
        }

        public Team GetTeamById(int teamId)
        {
            return AllTeams.FirstOrDefault(t => t.TeamId == teamId);
        }

        public void CreateTeam(NewTeamViewModel model)
        {

            Team newTeam = new Team
            {
                Name = model.Name,
                Location = model.Location,
                Players = new List<Player>()
            };
            _appDbContext.Teams.Add(newTeam);
            _appDbContext.SaveChanges();

            //create new object for each player
            foreach(var playa in model.Players)
            {
                Player newPlayer = new Player
                {
                    Name = playa,
                    TeamId = newTeam.TeamId
                };
                _appDbContext.Players.Add(newPlayer);
                
            }
            _appDbContext.SaveChanges();


        }
    }
}
