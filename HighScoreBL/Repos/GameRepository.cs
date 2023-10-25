using HighScoreBL.Repos.Interfaces;
using HighScoreDAL.Utils;
using HighScoreModels;
using HighScoreModels.ViewModels;

namespace HighScoreBL.Repos;

public class GameRepository : BaseRepository, IGameRepository
{
    public GameRepository(IHighScoreDataBase data) : base(data) { }

    public Game? GetGame(int gameId)
    {
        return _data.Games.FirstOrDefault(g => g.GameId == gameId);
    }

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

    public bool Remove(Game game)
    {
        return _data.Games.Remove(game);
    }

    public bool Remove(int gameId)
    {
        Game? game = GetGame(gameId);
        if (game != null)
            return _data.Games.Remove(game);
        return false; 
    }

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
