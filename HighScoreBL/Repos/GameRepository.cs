﻿using HighScoreBL.Repos.Interfaces;
using HighScoreModels;
using HighScoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos
{
    public class GameRepository : IGameRepository
    {
        public List<GameViewModel> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public Game? GetGame(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
