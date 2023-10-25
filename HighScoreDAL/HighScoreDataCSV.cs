using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDAL;

public class HighScoreDataCSV : HighScoreDataBase
{
    public override async Task<int> SaveAsync()
    {
        return (_games is null ? 0 : _games.Count) +
               (_players is null ? 0 : _players.Count) +
               (_highScores is null ? 0 : _highScores.Count);
    }

    protected override List<Game> LoadGames()
    {
        throw new NotImplementedException();
    }

    protected override List<HighScore> LoadHighScores()
    {
        throw new NotImplementedException();
    }

    protected override List<Player> LoadPlayers()
    {
        throw new NotImplementedException();
    }
}
