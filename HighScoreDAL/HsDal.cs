using HighScoreModels;

namespace HighScoreDAL
{
    public class HsDal : IHsDal
    {
        private List<Game>? _games;
        private List<Player>? _players;
        private List<HighScore>? _highScores;

        public string FilePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HighScore";
        public FileType FileType { get; set; } = FileType.json;

        public List<Game> Games 
        { 
            get { return _games ??= LoadGames(); }
        }

        public List<Player> Players 
        { 
            get { return _players ??= LoadPlayers(); }
        }

        public List<HighScore> HighScores 
        {
            get { return _highScores ??= LoadHighScores(); } 
        }

        public int Save()
        {
            switch(FileType)
            {
                case FileType.json:
                    SaveJson();
                    break;
                case FileType.xml:
                    SaveXML();
                    break;
                case FileType.csv:
                    SaveCSV();
                    break;
                default:
                    break;
            }
            return (_games is null ? 0 : _games.Count) + 
                   (_players is null ? 0 : _players.Count) + 
                   (_highScores is null ? 0 : _highScores.Count);
        }

        private List<Game> LoadGames()
        {
            throw new NotImplementedException() ;
        }

        private List<Player> LoadPlayers()
        {
            throw new NotImplementedException();
        }

        private List<HighScore> LoadHighScores()
        {
            throw new NotImplementedException();
        }

        private void SaveJson()
        {
            throw new NotImplementedException();
        }

        private void SaveXML()
        {
            throw new NotImplementedException();
        }

        private void SaveCSV()
        {
            throw new NotImplementedException();
        }
    }
}
