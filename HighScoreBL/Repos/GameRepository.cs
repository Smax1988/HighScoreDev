using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;
using HighScoreModels.ViewModels;

namespace HighScoreBL.Repos;

/// <summary>
/// This repository includes CRUD operations (Create, Read, Update, Delete) on the file database for a game.
/// </summary>
public class GameRepository : BaseRepository, IGameRepository
{
    public GameRepository(IHighScoreDataBase data) : base(data) { }

    /// <summary>
    /// Get a game by gameId from games database.
    /// </summary>
    /// <param name="gameId">The Id of the game</param>
    /// <returns>The found game or null if no game with given gameId is found</returns>
    public Game? GetGame(int gameId)
    {
        return _data.Games.FirstOrDefault(g => g.GameId == gameId);
    }

    /// <summary>
    /// Gets all games from games database.
    /// </summary>
    /// <returns>All games with their GameId and title wrapped in GameViewModel</returns>
    public List<GameViewModel> GetAllGames()
    {
        var games = from g in _data.Games
                    orderby g.Title
                    select new GameViewModel
                    {
                        GameId = g.GameId,
                        Title = g.Title
                    };
        return games.ToList();
    }

    /// <summary>
    /// Adds a game to the game database and creates a unique gameId.
    /// </summary>
    /// <param name="game">Game to be added</param>
    public void Add(Game game)
    {
        int nextId;
        try
        {
            nextId = _data.Games.Max(g => g.GameId) + 1;
        }
        catch (InvalidOperationException ex)
        {
            nextId = 1;
            _data.Games.Add(game);
        }
    }

    /// <summary>
    /// Deletes a game from the game database.
    /// </summary>
    /// <param name="game">The game to be deleted</param>
    /// <returns>True if game was successfully removed, false otherwise. Also returns false if game was not found.</returns>
    public bool Remove(Game game)
    {
        return _data.Games.Remove(game);
    }

    /// <summary>
    /// Deletes a game with a certain gameId from game database.
    /// </summary>
    /// <param name="gameId">The gameId of the game to be deleted.</param>
    /// <returns>True if game was successfully removed, false otherwise. Also returns false if game was not found.</returns>
    public bool Remove(int gameId)
    {
        Game? game = GetGame(gameId);
        if (game != null)
            return _data.Games.Remove(game);
        return false; 
    }

    /// <summary>
    /// Updates a given game in the game database.
    /// </summary>
    /// <param name="game">The game to be updated.</param>
    public void Update(Game game)
    {
        Game? g = GetGame(game.GameId);

        if (g != null)
        {
            g.GameId = game.GameId;
            g.Title = game.Title;
            g.Published = game.Published;
            g.Publisher = game.Publisher;
        }
    }
}
