using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        //private readonly ITeamRepository _teamRepository = new TeamRepository();
        public IEnumerable<Team> AllTeams =>
            new List<Team>
            {
                new Team {
                    TeamId = 1,
                    Name = "De Winnaars",
                    Players = new List<string>{
                        "speler 1",
                        "speler 2",
                        "speler 3",
                        "speler 4",
                        "speler 5",
                        "speler 6"},
                    Location = "locatie A"
                },
                new Team{
                    TeamId = 2,
                    Name = "De Verliezers",
                    Players = new List<string>{
                        "speler 1",
                        "speler 2",
                        "speler 3",
                        "speler 4",
                        "speler 5",
                        "speler 6"},
                    Location = "locatie B"
                }
            };

        public Team GetTeamById(int teamId)
        {
            return AllTeams.FirstOrDefault(t => t.TeamId == teamId);
        }
    }
}
