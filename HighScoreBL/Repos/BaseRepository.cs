using HighScoreDAL;
using HighScoreDAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos
{
    public class BaseRepository
    {
        protected readonly IHighScoreDataBase _data;

        public BaseRepository(IHighScoreDataBase data) { _data = data; }
    }
}
