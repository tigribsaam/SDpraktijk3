﻿using competitiemanager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _appDbConext;

        public GameRepository(AppDbContext appDbContext)
        {
            _appDbConext = appDbContext;
        }

        public Game GetGameById(int GameId)
        {
            throw new NotImplementedException();
        }
    }
}
