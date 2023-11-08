using HighScoreModels;

namespace HighScoreBL.Repos.Interfaces;

/// <summary>
/// Interface for the HighScoreRepository
/// </summary>
public interface IHighScoreRepository
{
    HighScore? GetHighScoreByGameIdByPlayerIdByScore(HighScore highscore);
    HighScore? GetHighscore(int highscoreId, int gameId);
    List<HighScore> GetAllHighscores();
    List<HighScore?> GetAllHighScoreByPlayerId(int playerId);
    List<HighScore?> GetAllHighScoreByGameId(int gameId);

    void Add(HighScore highscore);
    bool Remove(HighScore highscore);
}
