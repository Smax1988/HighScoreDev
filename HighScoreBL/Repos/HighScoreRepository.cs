using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;

namespace HighScoreBL.Repos;

/// <summary>
/// This repository includes CRUD operations (Create, Read, Update, Delete) on the file database for a highscore.
/// </summary>
public class HighScoreRepository : BaseRepository, IHighScoreRepository
{
    public HighScoreRepository(IHighScoreDataBase data) : base(data) { }

    /// <summary>
    /// Gets all highscroes for a certain player.
    /// </summary>
    /// <param name="playerId">id of player for which highscroes should be fetched.</param>
    /// <returns></returns>
    public List<HighScore?> GetAllHighScoreByPlayerId(int playerId)
    {
        return _data.HighScores.Where(h => h.PlayerId == playerId).ToList();
    }

    /// <summary>
    /// Gets all highscores for a certain game.
    /// </summary>
    /// <param name="gameId">id of game for which hichscores should be fetched.</param>
    /// <returns></returns>
    public List<HighScore?> GetAllHighScoreByGameId(int gameId)
    {
        return _data.HighScores.Where(h => h.GameId == gameId).ToList();
    }

    /// <summary>
    /// Gets a highscore by gameId, playerId and score.
    /// </summary>
    /// <param name="highscore">The highscore to be found</param>
    /// <returns>The found highscore or null if no highscore with given parameters was found</returns>
    public HighScore? GetHighScoreByGameIdByPlayerIdByScore(HighScore highscore)
    {
        return _data.HighScores.FirstOrDefault(h => h.GameId == highscore.GameId
                                                 && h.PlayerId == highscore.PlayerId
                                                 && h.Score == highscore.Score);
    }

    /// <summary>
    /// Gets a highscore by playerId and gameId.
    /// </summary>
    /// <param name="playerId">The highscore's playerId</param>
    /// <param name="gameId">The highscore's gameId</param>
    /// <returns>The found highscore or null if no highscore with the given parameters was found.</returns>
    public HighScore? GetHighscore(int playerId, int gameId)
    {
        return _data.HighScores.FirstOrDefault(h => h.PlayerId == playerId && h.GameId == gameId);
    }

    /// <summary>
    /// Gets all highscores from the highscore database.
    /// </summary>
    /// <returns>All highscores.</returns>
    public List<HighScore> GetAllHighscores()
    {
        var highscores = from h in _data.HighScores
                         orderby h.Score
                         select new HighScore
                         {
                             PlayerId = h.PlayerId,
                             GameId = h.GameId,
                             Score = h.Score
                         };
        return highscores.ToList();
    }

    /// <summary>
    /// Adds a highscore to the highscore database.
    /// If a highscore for playerId and gameId exists already, the score date will be updated.
    /// </summary>
    /// <param name="highscore">The highscore to be added.</param>
    public void Add(HighScore highscore)
    {
        var sameScoreAndPlayer = GetHighScoreByGameIdByPlayerIdByScore(highscore);
        if (sameScoreAndPlayer == null)
        {
            _data.HighScores.Add(highscore);
        }
        else
        {
            sameScoreAndPlayer.ScoreDate = DateTime.Now;
        }
    }

    /// <summary>
    /// Deletes a highscore from highscore database.
    /// </summary>
    /// <param name="highscore">The highscore to be deleted.</param>
    /// <returns>True if highscore was successfully removed, false otherwise. Also returns false if highscore was not found.</returns>
    public bool Remove(HighScore highscore)
    {
        return _data.HighScores.Remove(highscore);
    }

}
