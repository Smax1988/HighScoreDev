﻿using HighScoreBL.Repos.Interfaces;
using HighScoreDAL;
using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos
{
    internal class HighScoreRepository : IHighScoreRepository
    {
        public List<HighScore> GetAllHighscores()
        {
            throw new NotImplementedException();
        }

        public HighScore? GetHighscore(int highscoreId)
        {
            throw new NotImplementedException();
        }
    }
}
