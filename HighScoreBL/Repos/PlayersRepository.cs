using HighScoreBL.Repos.Interfaces;
using HighScoreDAL;
using HighScoreDAL.Utils;
using HighScoreModels;
using HighScoreModels.ViewModels;

namespace HighScoreBL.Repos;

public class PlayersRepository : BaseRepository, IPlayersRepository
{
    public PlayersRepository(IHighScoreDataBase data) : base (data) {} 

    public Player? GetPlayer(int playerId)
    {
        return _data.Players.FirstOrDefault(p => p.PlayerId == playerId);
    }

    public List<PlayerViewModel> GetAllPlayers()
    {
        var players = from p in _data.Players
                      orderby p.Nickname
                      select new PlayerViewModel
                      {
                          PlayerId = p.PlayerId,
                          Email = p.Email,
                          Nickname = p.Nickname
                      };
        return players.ToList();
    }

    public List<PlayerPerGameViewModel> GetAllPlayers(int GameId)
    {
        throw new NotImplementedException();
    }

    public void Add(Player player)
    {
        int nextID;
        try
        {
            nextID = _data.Players.Max(p => p.PlayerId) + 1;
        }
        catch (InvalidOperationException ex)
        {
            nextID = 1;
        }
        player.PlayerId = nextID;
        _data.Players.Add(player);
    }

    public bool Remove(Player player)
    {
        return _data.Players.Remove(player);
    }

    public bool Remove(int playerId)
    {
        Player? player = GetPlayer(playerId);
        if (player != null)
            return _data.Players.Remove(player);
        return false;
    }

    public void Update(Player player)
    {
        Player? p = GetPlayer(player.PlayerId);

        if (p != null)
        {
            p.FirstName = player.FirstName;
            p.LastName = player.LastName;
            p.Birthday = player.Birthday;
            p.Nickname = player.Nickname;
            p.IsActive = player.IsActive;
            p.Notes = player.Notes;
            p.Email = player.Email;
            p.Entry = player.Entry;
            p.Exit = player.Exit;
        }
    }
}
