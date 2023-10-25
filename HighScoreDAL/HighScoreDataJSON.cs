using HighScoreDAL.Utils;
using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HighScoreDAL;

public class HighScoreDataJSON : HighScoreDataBase
{
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

    protected override List<Game> LoadGames()
    {
        JsonDocument data = LoadJson();
        JsonElement games = data.RootElement.GetProperty("Games");
        return JsonSerializer.Deserialize<List<Game>>(games.GetRawText()) ?? new List<Game>();
    }

    protected override List<HighScore> LoadHighScores()
    {
        JsonDocument data = LoadJson();
        JsonElement highscores = data.RootElement.GetProperty("HighScores");
        return JsonSerializer.Deserialize<List<HighScore>>(highscores.GetRawText()) ?? new List<HighScore>();
    }

    protected override List<Player> LoadPlayers()
    {
        JsonDocument jsonData = LoadJson();
        JsonElement players = jsonData.RootElement.GetProperty("Players");
        return JsonSerializer.Deserialize<List<Player>>(players.GetRawText()) ?? new List<Player>();
    }

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
