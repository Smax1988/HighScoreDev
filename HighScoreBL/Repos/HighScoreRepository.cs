using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;

namespace HighScoreBL.Repos;

public class HighScoreRepository : BaseRepository, IHighScoreRepository
{
    public HighScoreRepository(IHighScoreDataBase data) : base(data) { }
    
    public List<HighScore> GetAllHighscores()
    {
        throw new NotImplementedException();
    }

    public HighScore? GetHighscore(int highscoreId)
    {
        throw new NotImplementedException();
    }
}
