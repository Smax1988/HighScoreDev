using HighScoreModels;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Reflection.PortableExecutable;
using System.Data.SqlTypes;

namespace HighScoreDAL;

public class HighScoreData : IHighScoreData
{
    private List<Game>? _games;
    private List<Player>? _players;
    private List<HighScore>? _highScores;

    public string FilePath { get; set; } = "../../../../HighScoreDAL/data/";
    public FileType FileType { get; set; } = FileType.json;

    public List<Game> Games
    {
        get { return _games ??= LoadGames(); }
    }

    public List<Player> Players
    {
        get { return _players ??= LoadPlayers(); }
    }

    public List<HighScore> HighScores
    {
        get { return _highScores ??= LoadHighScores(); }
    }

    public int Save()
    {
        switch (FileType)
        {
            case FileType.json:
                SaveJson();
                break;
            case FileType.xml:
                SaveXML();
                break;
            case FileType.csv:
                SaveCSV();
                break;
            default:
                break;
        }
        return (_games is null ? 0 : _games.Count) +
               (_players is null ? 0 : _players.Count) +
               (_highScores is null ? 0 : _highScores.Count);
    }

    private List<Game> LoadGames()
    {
        switch (FileType)
        {
            case FileType.json:
                JsonDocument data = LoadJson();
                JsonElement games = data.RootElement.GetProperty("Games");
                return JsonSerializer.Deserialize<List<Game>>(games.GetRawText()) ?? new List<Game>();
            case FileType.xml:
                return LoadXml<Game>();
            case FileType.csv:
                return new List<Game>();
            default:
                throw new NotSupportedException("File type must be .json, .xml or .csv");
        }
    }

    private List<Player> LoadPlayers()
    {
        switch (FileType)
        {
            case FileType.json:
                JsonDocument jsonData = LoadJson();
                JsonElement players = jsonData.RootElement.GetProperty("Players");
                return JsonSerializer.Deserialize<List<Player>>(players.GetRawText()) ?? new List<Player>();
            case FileType.xml:
                return LoadXml<Player>();
            case FileType.csv:
                return new List<Player>();
            default:
                throw new NotSupportedException("File type must be .json, .xml or .csv");
        }
    }

    private List<HighScore> LoadHighScores()
    {
        switch (FileType)
        {
            case FileType.json:
                JsonDocument data = LoadJson();
                JsonElement highscores = data.RootElement.GetProperty("HighScores");
                return JsonSerializer.Deserialize<List<HighScore>>(highscores.GetRawText()) ?? new List<HighScore>();
            case FileType.xml:
                return LoadXml<HighScore>();
            case FileType.csv:
                return new List<HighScore>();
            default:
                throw new NotSupportedException("File type must be .json, .xml or .csv");
        }
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

    private void LoadCSV()
    {
        throw new NotImplementedException();
    }

    private List<T> LoadXml<T>()
{
    string xmlString;
    using (var streamReader = new StreamReader(FilePath + "data.xml"))
    {
        xmlString = streamReader.ReadToEnd();
    }

    XmlDocument xmlDoc = new XmlDocument();
    xmlDoc.LoadXml(xmlString);

    if (typeof(T) == typeof(Game))
    {
        List<Game> games = new List<Game>();
        XmlNodeList gameNodes = xmlDoc.SelectNodes("//root/games/game")!;

        foreach (XmlNode gameNode in gameNodes)
        {
            ParseGames(games, gameNode);
        }
        return games as List<T> ?? new List<T>();
    }
    else if (typeof(T) == typeof(Player))
    {
        List<Player> players = new List<Player>();
        XmlNodeList playerNodes = xmlDoc.SelectNodes("//root/players/player")!;

        foreach (XmlNode playerNode in playerNodes)
        {
            ParsePlayers(players, playerNode);
        }
        return players as List<T> ?? new List<T>();
    }
    else if (typeof(T) == typeof(HighScore))
    {
        List<HighScore> highscores = new List<HighScore>();
        XmlNodeList highscoreNodes = xmlDoc.SelectNodes("//root/highscores/highscore")!;

        foreach (XmlNode highscoreNode in highscoreNodes)
        {
            ParseHighscores(highscores, highscoreNode);
        }
        return highscores as List<T> ?? new List<T>();
    }
    else
    {
        throw new NotSupportedException("File type must be .json, .xml, or .csv");
    }
}


    private static void ParseHighscores(List<HighScore> highscores, XmlNode highscoreNode)
    {
        HighScore highscore = new HighScore();
        highscore.GameId = Convert.ToInt32(highscoreNode.SelectSingleNode("GameId")?.InnerText);
        highscore.PlayerId = Convert.ToInt32(highscoreNode.SelectSingleNode("PlayerId")?.InnerText);
        highscore.Score = Convert.ToInt32(highscoreNode.SelectSingleNode("Score")?.InnerText);
        highscore.ScoreDate = DateTime.Parse(highscoreNode.SelectSingleNode("ScoreDate")!.InnerText);

        highscores.Add(highscore);
    }

    private static void ParsePlayers(List<Player> players, XmlNode playerNode)
    {
        Player player = new Player();
        player.PlayerId = Convert.ToInt32(playerNode.SelectSingleNode("PlayerId")!.InnerText);
        player.Nickname = playerNode.SelectSingleNode("Nickname")!.InnerText;
        player.Email = playerNode.SelectSingleNode("Email")!.InnerText;
        player.Birthday = DateTime.Parse(playerNode.SelectSingleNode("Birthday")!.InnerText);
        player.FirstName = playerNode.SelectSingleNode("FirstName")!.InnerText;
        player.LastName = playerNode.SelectSingleNode("LastName")!.InnerText;
        player.Entry = DateTime.Parse(playerNode.SelectSingleNode("Entry")!.InnerText);
        player.Exit = DateTime.Parse(playerNode.SelectSingleNode("Exit")!.InnerText);
        player.IsActive = Convert.ToBoolean(playerNode.SelectSingleNode("IsActive")?.InnerText);
        player.Notes = playerNode.SelectSingleNode("Notes")!.InnerText;

        players.Add(player);
    }

    private static void ParseGames(List<Game> games, XmlNode gameNode)
    {
        Game game = new Game();
        game.GameId = Convert.ToInt32(gameNode.SelectSingleNode("GameId")?.InnerText);
        game.Title = gameNode.SelectSingleNode("Title")!.InnerText;
        game.Published = DateTime.Parse(gameNode.SelectSingleNode("Published")!.InnerText);
        game.Publisher = gameNode.SelectSingleNode("Publisher")!.InnerText;
        game.Entry = DateTime.Parse(gameNode.SelectSingleNode("Entry")!.InnerText);
        game.Exit = DateTime.Parse(gameNode.SelectSingleNode("Exit")!.InnerText);
        game.IsActive = Convert.ToBoolean(gameNode.SelectSingleNode("IsActive")?.InnerText);
        game.Notes = gameNode.SelectSingleNode("Notes")!.InnerText;

        games.Add(game);
    }

    private async Task SaveJson()
    {
        DataTransferObject dto = new DataTransferObject();
        dto.Players = Players;
        dto.Games = Games;
        dto.HighScores = HighScores;

        using (FileStream fs = new FileStream(FilePath + "data.json", FileMode.Create, FileAccess.Write))
        {
            await JsonSerializer.SerializeAsync(fs, dto);
        }
    }

    private void SaveXML()
    {
        throw new NotImplementedException();
    }

    private void SaveCSV()
    {
        throw new NotImplementedException();
    }
}
