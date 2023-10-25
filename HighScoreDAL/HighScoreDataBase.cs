using HighScoreDAL.Utils;
using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDAL;

public abstract class HighScoreDataBase : IHighScoreDataBase
{
    protected List<Game>? _games;
    protected List<Player>? _players;
    protected List<HighScore>? _highScores;

    public string FilePath { get; set; } = "../../../../HighScoreDAL/data/";
    public FileType FileType { get; set; } = FileType.json;

    public List<Game> Games
    {
        get { return _games ??= LoadGames(); }
    }

    public List<Player> Players 
    {
        get { return _players ??= LoadPlayers(); }
    }

    public List<HighScore> HighScores
    {
        get { return _highScores ??= LoadHighScores(); }
    }

    public void Rollback()
    {
        _games = null;
        _highScores = null;
        _players = null;
    }

    public abstract Task<int> SaveAsync();
    protected abstract List<Game> LoadGames();
    protected abstract List<Player> LoadPlayers();
    protected abstract List<HighScore> LoadHighScores();
}
