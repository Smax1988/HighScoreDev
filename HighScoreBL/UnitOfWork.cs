using HighScoreBL.Repos;
using HighScoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL;

public class UnitOfWork
{
    private readonly HighScoreData data = new HighScoreData();
    private PlayersRepository? playersRepo;
    private GameRepository? gameRepo;
    private HighScoreRepository? highScoreRepo;

    public PlayersRepository Players
    {
        get
        {
            return playersRepo ??= new PlayersRepository(data);
        }
    }

    public GameRepository Games
    {
        get 
        {
            return gameRepo ??= new GameRepository(data); 
        }
    }

    public HighScoreRepository HighScores
    {
        get
        {
            return highScoreRepo ??= new HighScoreRepository(data);
        }
    }

    public int Commit()
    {
        return data.Save();
    }

    public void Rollback()
    {
        throw new NotImplementedException();
    }
}
