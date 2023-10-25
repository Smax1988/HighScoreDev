using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDAL.Utils
{
    public interface IHighScoreDataBase
    {
        public string FilePath { get; set; }
        public FileType FileType { get; set; }
        public List<Game> Games { get; }
        public List<Player> Players { get; }
        public List<HighScore> HighScores { get; }

        /// <summary>
        /// Save all Lists to json, csv or xml file
        /// </summary>
        /// <returns>Number of insertions</returns>
        Task<int> SaveAsync();
        void Rollback();
    }

    public enum FileType
    {
        json,
        csv,
        xml
    }
}
