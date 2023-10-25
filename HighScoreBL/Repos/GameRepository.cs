using HighScoreBL.Repos.Interfaces;
using HighScoreDAL;
using HighScoreDAL.Utils;
using HighScoreModels;
using HighScoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos;

public class GameRepository : BaseRepository, IGameRepository
{
    public GameRepository(IHighScoreDataBase data) : base(data) { }

    public List<GameViewModel> GetAllGames()
    {
        throw new NotImplementedException();
    }

    public Game? GetGame(int gameId)
    {
        throw new NotImplementedException();
    }
}
