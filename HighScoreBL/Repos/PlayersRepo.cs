using HighScoreDAL;
using HighScoreModels;
using HighScoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreBL.Repos
{
    public class PlayersRepo : IPlayersRepo
    {
        private readonly HsDal dal;

        public PlayersRepo(HsDal hsdal)
        {
            dal = hsdal;
        }
        public Player? GetPlayer(int playerId)
        {
            return dal.Players.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public List<PlayerPerGame> GetAllPlayers()
        {
            var players = from p in dal.Players
                          orderby p.Nickname
                          select new PlayerPerGame
                          {
                              PlayerId = p.PlayerId,
                              Email = p.Email,
                              Nickname = p.Nickname
                          };
            return players.ToList();
        }
    }
}
