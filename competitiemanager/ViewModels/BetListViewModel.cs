﻿using competitiemanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.ViewModels
{
    public class BetListViewModel
    {
        public IEnumerable<Bet> Bets { get; set; }
    }
}
