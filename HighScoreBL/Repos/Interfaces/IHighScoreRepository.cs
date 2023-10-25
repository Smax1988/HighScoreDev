using HighScoreModels;

namespace HighScoreBL.Repos.Interfaces
{
    public interface IHighScoreRepository
    {
        HighScore? GetHighscore(int highscoreId);
        List<HighScore> GetAllHighscores();

        void Add(HighScore highscore);
        bool Remove(HighScore highscore);
        bool Remove(int highscroeId);
        void Update(HighScore highscore);
    }
}
