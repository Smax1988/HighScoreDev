using HighScoreDAL.Utils;
using HighScoreModels;

namespace HighScoreDAL;

/// <summary>
/// Base class for all data access layers (JSON, XML, CSV).
/// Provides the file path and file type to the file database and a representation of the data in list form.
/// Provides also a rollback functionality.
/// </summary>
public abstract class HighScoreDataBase : IHighScoreDataBase
{
    protected List<Game>? _games;
    protected List<Player>? _players;
    protected List<HighScore>? _highScores;

    public string FilePath { get; set; } = "../../../../HighScoreDAL/data/";

    public FileType FileType { get; set; } = FileType.json;

    public List<Game> Games { get => _games ??= LoadGames(); }

    public List<Player> Players { get => _players ??= LoadPlayers(); }

    public List<HighScore> HighScores { get => _highScores ??= LoadHighScores(); }

    public void Rollback()
    {
        _games = null;
        _highScores = null;
        _players = null;
    }

    /// <summary>
    /// Saves all data for Games, Players and Highscores to a file.
    /// </summary>
    /// <returns></returns>
    public abstract Task<int> SaveAsync();

    /// <summary>
    /// Loads all data for games from file database.
    /// </summary>
    /// <returns>All game data.</returns>
    protected abstract List<Game> LoadGames();

    /// <summary>
    /// Loads all data for players from the file database.
    /// </summary>
    /// <returns>All player data.</returns>
    protected abstract List<Player> LoadPlayers();

    /// <summary>
    /// Loads all data for highscores from the file database.
    /// </summary>
    /// <returns>All highscore data.</returns>
    protected abstract List<HighScore> LoadHighScores();
}
