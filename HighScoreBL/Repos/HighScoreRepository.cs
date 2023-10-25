using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;

namespace HighScoreBL.Repos;

public class HighScoreRepository : BaseRepository, IHighScoreRepository
{
    public HighScoreRepository(IHighScoreDataBase data) : base(data) { }

    public HighScore? GetHighscore(int highscoreId)
    {
        throw new NotImplementedException();
    }

    public List<HighScore> GetAllHighscores()
    {
        throw new NotImplementedException();
    }

    public void Add(HighScore highscore)
    {
        throw new NotImplementedException();
    }

    public bool Remove(HighScore highscore)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int highscroeId)
    {
        throw new NotImplementedException();
    }

    public void Update(HighScore highscore)
    {
        throw new NotImplementedException();
    }
}
