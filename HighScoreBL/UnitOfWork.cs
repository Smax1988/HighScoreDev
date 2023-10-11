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
    private PlayersRepo? playersRepo;
    private readonly HsDal dal = new HsDal();


    public PlayersRepo Players
    {
        get
        {
            return playersRepo ??= new PlayersRepo(dal);
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
