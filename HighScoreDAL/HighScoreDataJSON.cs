using HighScoreDAL.Utils;
using HighScoreModels;
using System.Text.Json;

namespace HighScoreDAL;

/// <summary>
/// Provides saving and loading data to the file database in json format.
/// </summary>
public class HighScoreDataJSON : HighScoreDataBase
{
    /// <summary>
    /// Async method to save all data to the file database in json format.
    /// </summary>
    /// <returns>Number of entries saved.</returns>
    public override async Task<int> SaveAsync()
    {
        DataTransferObject dto = new DataTransferObject();
        dto.Players = Players;
        dto.Games = Games;
        dto.HighScores = HighScores;
        //DEBUG dto.Players.Add(new Player { FirstName = "Test_Player", LastName = "Test_Player", PlayerId = 100000, Notes = "________________", Nickname = "TEST", Email = "TEST" });

        using (FileStream fs = new FileStream(FilePath + "data.json", FileMode.Create, FileAccess.Write))
        {
            await JsonSerializer.SerializeAsync(fs, dto);
        }
        return (_games is null ? 0 : _games.Count) +
               (_players is null ? 0 : _players.Count) +
               (_highScores is null ? 0 : _highScores.Count);
    }

    /// <summary>
    /// Loads all data for games from json file database
    /// </summary>
    /// <returns>All game data.</returns>
    protected override List<Game> LoadGames()
    {
        JsonDocument data = LoadJson();
        JsonElement games = data.RootElement.GetProperty("Games");
        return JsonSerializer.Deserialize<List<Game>>(games.GetRawText()) ?? new List<Game>();
    }

    /// <summary>
    /// Loads all data for highscore from json file database.
    /// </summary>
    /// <returns>All highscore data.</returns>
    protected override List<HighScore> LoadHighScores()
    {
        JsonDocument data = LoadJson();
        JsonElement highscores = data.RootElement.GetProperty("HighScores");
        return JsonSerializer.Deserialize<List<HighScore>>(highscores.GetRawText()) ?? new List<HighScore>();
    }

    /// <summary>
    /// Loads all data for players from json file database.
    /// </summary>
    /// <returns>All player data.</returns>
    protected override List<Player> LoadPlayers()
    {
        JsonDocument jsonData = LoadJson();
        JsonElement players = jsonData.RootElement.GetProperty("Players");
        return JsonSerializer.Deserialize<List<Player>>(players.GetRawText()) ?? new List<Player>();
    }

    /// <summary>
    /// Loads all data from json file database.
    /// </summary>
    /// <returns>All data as json string.</returns>
    private JsonDocument LoadJson()
    {
        string jsonContent;
        using (var fileStream = new FileStream(FilePath + "data.json", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (var streamReader = new StreamReader(fileStream))
            {
                jsonContent = streamReader.ReadToEnd();
            }
        }
        return JsonDocument.Parse(jsonContent);
    }
}
