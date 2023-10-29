using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;
using HighScoreModels.ViewModels;

namespace HighScoreBL.Repos;

/// <summary>
/// This repository includes CRUD operations (Create, Read, Update, Delete) on the file database for a player.
/// </summary>
public class PlayersRepository : BaseRepository, IPlayersRepository
{
    public PlayersRepository(IHighScoreDataBase data) : base (data) {}

    /// <summary>
    /// Get a player by playerId from player database.
    /// </summary>
    /// <param name="playerId">The Id of the player</param>
    /// <returns>The found player or null if no player with given playerId is found</returns>
    public Player? GetPlayer(int playerId)
    {
        return _data.Players.FirstOrDefault(p => p.PlayerId == playerId);
    }

    /// <summary>
    /// Gets all player from player database.
    /// </summary>
    /// <returns>All players with their PlayerId, Email and Nickname wrapped in a PlayerViewModel</returns>
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

    public List<PlayerPerGameViewModel> GetAllPlayers(int gameId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a player to the player database and creates a unique playerId.
    /// </summary>
    /// <param name="player">Player to be added</param>
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

    /// <summary>
    /// Deletes a player from the player database.
    /// </summary>
    /// <param name="player">Player to be deleted</param>
    /// <returns>True if player was successfully removed, false otherwise. Also returns false if player was not found.</returns>
    public bool Remove(Player player)
    {
        return _data.Players.Remove(player);
    }

    /// <summary>
    /// Deletes a player with a certain playerId from the database.
    /// </summary>
    /// <param name="playerId">The playerId of the player to be deleted.</param>
    /// <returns>True if player was successfully removed, false otherwise. Also returns false if player was not found.</returns>
    public bool Remove(int playerId)
    {
        Player? player = GetPlayer(playerId);
        if (player != null)
            return _data.Players.Remove(player);
        return false;
    }

    /// <summary>
    /// Updates a given player in the player database.
    /// </summary>
    /// <param name="player">The player to be updated</param>
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
