using HighScoreBL.Repos;
using HighScoreDAL;
using HighScoreDAL.Utils;

namespace HighScoreBL;

/// <summary>
/// This Unit of Work sets the data access to the corresponding file type. It manages the instances of all repositories.
/// You can choose from Json, XML or CSV as file type for the file database. 
/// </summary>
public class UnitOfWork
{
    private readonly IHighScoreDataBase _data;
    private PlayersRepository? _playersRepo;
    private GameRepository? _gameRepo;
    private HighScoreRepository? _highScoreRepo;

    /// <summary>
    /// Sets the correct instance of the HighScore data access layer according to the chosen file type of the file database.
    /// </summary>
    /// <param name="fileType">The file database can be in JSON, XML or CSV format</param>
    /// <exception cref="ArgumentOutOfRangeException">Throws if an invalid file type is selected</exception>
    public UnitOfWork(FileType fileType = FileType.json)
    {
        switch (fileType)
        {
            case FileType.json:
                _data = new HighScoreDataJSON();
                break;
            case FileType.xml:
                _data = new HighScoreDataXML();
                break;
            case FileType.csv:
                _data = new HighScoreDataCSV();
                break;
            default:
                throw new ArgumentOutOfRangeException("FileType not supported. Choose Json, XML or CSV");
        }
    }

    public PlayersRepository PlayersRepo { get => _playersRepo ??= new PlayersRepository(_data); }
    public GameRepository GamesRepo { get => _gameRepo ??= new GameRepository(_data); }
    public HighScoreRepository HighScoresRepo { get => _highScoreRepo ??= new HighScoreRepository(_data); }

    /// <summary>
    /// Async Method to save changes to file database
    /// </summary>
    /// <returns>Number of entries saved to the file database</returns>
    public async Task<int> Commit()
    {
        return await _data.SaveAsync();
    }

    /// <summary>
    /// Discards changes and restores file database
    /// </summary>
    public void Rollback()
    {
        _data.Rollback();
    }
}
