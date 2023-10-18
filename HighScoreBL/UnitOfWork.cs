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
    private PlayersRepository? playersRepo;
    private readonly HighScoreData dal = new HighScoreData();


    public PlayersRepository Players
    {
        get
        {
            return playersRepo ??= new PlayersRepository(dal);
        }
    }

    public int Commit()
    {
        return dal.Save();
    }

    public void Rollback()
    {
        throw new NotImplementedException();
    }
}
