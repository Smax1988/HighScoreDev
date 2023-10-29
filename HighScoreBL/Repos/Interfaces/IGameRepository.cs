using HighScoreModels.ViewModels;
using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos.Interfaces;

/// <summary>
/// Interface for the GameRepository
/// </summary>
public interface IGameRepository
{
    Game? GetGame(int gameId);
    List<GameViewModel> GetAllGames();

    void Add(Game game);
    bool Remove(Game game);
    bool Remove(int gameId);
    void Update(Game game);
}
