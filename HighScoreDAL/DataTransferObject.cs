using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDAL
{
    internal class DataTransferObject
    {
        public List<Game> Games = new List<Game>();
        public List<Player> Players = new List<Player>();
        public List<HighScore> HighScores = new List<HighScore>();
    }
}
