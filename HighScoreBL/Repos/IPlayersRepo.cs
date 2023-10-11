using HighScoreModels;
using HighScoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos
{
    public interface IPlayersRepo
    {
        Player? GetPlayer(int playerId);
        List<PlayerPerGame> GetAllPlayers();

        // Add
        // Remove
        // Update

        // List<PlayerPerGame> GetPlayers(int GameId);

    }
}
