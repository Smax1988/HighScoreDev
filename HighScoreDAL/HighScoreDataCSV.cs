using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDAL;

/// <summary>
/// Provides saving and loading data to the file database in csv format.
/// </summary>
public class HighScoreDataCSV : HighScoreDataBase
{
    public override async Task<int> SaveAsync()
    {
        throw new NotImplementedException();
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
