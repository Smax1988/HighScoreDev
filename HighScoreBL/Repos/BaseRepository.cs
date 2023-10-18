using HighScoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos
{
    public class BaseRepository
    {
        protected readonly HighScoreData _data;

        public BaseRepository(HighScoreData data) { _data = data; }
    }
}
