using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;
using System.Numerics;

namespace HighScoreBL.Repos;

public class HighScoreRepository : BaseRepository, IHighScoreRepository
{
    public HighScoreRepository(IHighScoreDataBase data) : base(data) { }

    public HighScore? GetHighScoreByGameIdByPlayerIdByScore(HighScore highscore)
    {
        return _data.HighScores.FirstOrDefault(h => h.GameId == highscore.GameId
                                                                 && h.PlayerId == highscore.PlayerId
                                                                 && h.Score == highscore.Score);
    }

    public HighScore? GetHighscore(int playerId, int gameId)
    {
        return _data.HighScores.FirstOrDefault(h => h.PlayerId == playerId && h.GameId == gameId);
    }

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

    public void Add(HighScore highscore)
    {
        var sameScoreAndPlayer = GetHighScoreByGameIdByPlayerIdByScore(highscore);
        if (sameScoreAndPlayer == null)
        {
            _data.HighScores.Add(highscore);
        }
        else
        {
            //if (sameScoreAndPlayer.Score == highscore.Score)
            //    highscore.

        }
    }

    public bool Remove(HighScore highscore)
    {
        return _data.HighScores.Remove(highscore);
    }

    public void Update(HighScore highscore)
    {
        
    }
}
