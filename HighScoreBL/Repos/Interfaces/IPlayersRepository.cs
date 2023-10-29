using HighScoreModels;
using HighScoreModels.ViewModels;

namespace HighScoreBL.Repos.Interfaces;

/// <summary>
/// Interface for the PlayersRepository
/// </summary>
public interface IPlayersRepository
{
    Player? GetPlayer(int playerId);
    List<PlayerViewModel> GetAllPlayers();
    List<PlayerPerGameViewModel> GetAllPlayers(int GameId);

    void Add(Player player);
    bool Remove(Player player);
    bool Remove(int playerId);
    void Update(Player player);
}
