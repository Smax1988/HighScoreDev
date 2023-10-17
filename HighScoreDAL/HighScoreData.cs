using HighScoreModels;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace HighScoreDAL;

public class HighScoreData : IHighScoreData
{
    private List<Game>? _games;
    private List<Player>? _players;
    private List<HighScore>? _highScores;

    public string FilePath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HighScore";
    public FileType FileType { get; set; } = FileType.json;

    public List<Game> Games
    {
        get { return _games ??= LoadGames(); }
    }

    [XmlElement("players")]
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
                JsonElement games = data.RootElement[0].GetProperty("games");
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
                JsonElement players = jsonData.RootElement[0].GetProperty("players");
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
                JsonElement highscores = data.RootElement[0].GetProperty("highscores");
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
        string jsonContent = File.ReadAllText(FilePath + "\\data.json");
        return JsonDocument.Parse(jsonContent);
    }

    private void LoadCSV()
    {
        throw new NotImplementedException();
    }

    private List<T> LoadXml<T>()
    {
        string data = File.ReadAllText(FilePath + "\\data.xml");
        XDocument doc = XDocument.Parse(data);

        if (typeof(T) == typeof(Game))
        {
            var games = doc.Descendants("games").Elements("game");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Game>));
            using (StringReader reader = new StringReader(games.ToString()))
            {
                List<Game> gameList = (List<Game>)serializer.Deserialize(reader);
                return gameList as List<T>;
            }
        }
        else if (typeof(T) == typeof(Player))
        {
            var players = doc.Descendants("players").Elements("player");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
            using (StringReader reader = new StringReader(players.ToString()))
            {
                List<Player> playerList = (List<Player>)serializer.Deserialize(reader);
                return playerList as List<T>;
            }
        }
        else if (typeof(T) == typeof(HighScore))
        {
            var highScores = doc.Descendants("highScores").Elements("highScore");
            XmlSerializer serializer = new XmlSerializer(typeof(List<HighScore>));
            using (StringReader reader = new StringReader(highScores.ToString()))
            {
                List<HighScore> highScoreList = (List<HighScore>)serializer.Deserialize(reader);
                return highScoreList as List<T>;
            }
        }
        else
        {
            throw new NotSupportedException("File type must be .json, .xml, or .csv");
        }
    }



    private void SaveJson()
    {
        throw new NotImplementedException();
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
