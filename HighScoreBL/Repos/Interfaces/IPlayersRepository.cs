using HighScoreModels;
using HighScoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos.Interfaces
{
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
}
