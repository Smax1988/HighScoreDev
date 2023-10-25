using HighScoreBL.Repos;
using HighScoreDAL;
using HighScoreDAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                break;
            case FileType.xml:
                break;
            default:
                break;
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
        return await _data.Save();
    }

    public void Rollback()
    {
        throw new NotImplementedException();
    }
}
