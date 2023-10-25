using HighScoreModels.ViewModels;
using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos.Interfaces
{
    public interface IHighScoreRepository
    {
        HighScore? GetHighscore(int highscoreId);
        List<HighScore> GetAllHighscores();

    }
}
