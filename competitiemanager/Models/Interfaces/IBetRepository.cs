using competitiemanager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Interfaces
{
    public interface IBetRepository
    {
        IEnumerable<Bet> AllBets { get; }
        Bet GetBetById(int BetId);
        void PlaceBet(BetFormViewModel model);

    }
}
