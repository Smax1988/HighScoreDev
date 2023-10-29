using HighScoreModels;

namespace HighScoreDAL.Utils;

/// <summary>
/// Interface for the data access layer.
/// </summary>
public interface IHighScoreDataBase
{
    /// <summary>
    /// File path to the file database.
    /// </summary>
    public string FilePath { get; set; }

    /// <summary>
    /// File type of the file database. Can be JSON, XML or CSV.
    /// </summary>
    public FileType FileType { get; set; }

    /// <summary>
    /// Location where data for games from database is stored.
    /// </summary>
    public List<Game> Games { get; }

    /// <summary>
    /// Location where data for players from database is stored.
    /// </summary>
    public List<Player> Players { get; }

    /// <summary>
    /// Location where data for highscores from database is stored.
    /// </summary>
    public List<HighScore> HighScores { get; }

    /// <summary>
    /// Async method to save all data to the file database.
    /// </summary>
    /// <returns>Number of entries saved.</returns>
    Task<int> SaveAsync();

    /// <summary>
    /// Discards changes by loading all data again.
    /// </summary>
    void Rollback();
}

/// <summary>
/// Enum for file type. Can be JSON, XML or CSV.
/// </summary>
public enum FileType
{
    json,
    csv,
    xml
}
