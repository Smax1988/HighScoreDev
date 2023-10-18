using HighScoreBL.Repos.Interfaces;
using HighScoreDAL;
using HighScoreModels;
using HighScoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos;

public class PlayersRepository : BaseRepository, IPlayersRepository
{
    public PlayersRepository(HighScoreData data) : base (data) {} 
    public Player? GetPlayer(int playerId)
    {
        return _data.Players.FirstOrDefault(p => p.PlayerId == playerId);
    }

    public List<PlayerPerGameViewModel> GetAllPlayers()
    {
        var players = from p in _data.Players
                      orderby p.Nickname
                      select new PlayerPerGameViewModel
                      {
                          PlayerId = p.PlayerId,
                          Email = p.Email,
                          Nickname = p.Nickname
                      };
        return players.ToList();
    }
}
