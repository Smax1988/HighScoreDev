using HighScoreBL.Repos;
using HighScoreDAL;
using HighScoreDAL.Utils;

namespace HighScoreBL;

public class UnitOfWork
{
    private readonly IHighScoreDataBase _data;
    private PlayersRepository? _playersRepo;
    private GameRepository? _gameRepo;
    private HighScoreRepository? _highScoreRepo;

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

    public PlayersRepository PlayersRepo
    {
        get
        {
            return _playersRepo ??= new PlayersRepository(_data);
        }
    }

    public GameRepository GamesRepo
    {
        get 
        {
            return _gameRepo ??= new GameRepository(_data); 
        }
    }

    public HighScoreRepository HighScoresRepo
    {
        get
        {
            return _highScoreRepo ??= new HighScoreRepository(_data);
        }
    }

    public async Task<int> Commit()
    {
        return await _data.SaveAsync();
    }

    public void Rollback()
    {
        throw new NotImplementedException();
    }
}
