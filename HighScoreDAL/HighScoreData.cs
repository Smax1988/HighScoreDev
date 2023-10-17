using HighScoreModels;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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
        switch(FileType)
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
                return LoadJson<Game>();
            case FileType.xml:
                return LoadXML<Game>();
            case FileType.csv:
                return LoadCSV<Game>();
            default:
                throw new ArgumentOutOfRangeException("File type not supported.");
        }
    }

    private List<Player>? LoadPlayers()
    {
        switch (FileType)
        {
            case FileType.json:
                return LoadJson<Player>();
            case FileType.xml:
                return LoadXML<Player>();
            case FileType.csv:
                return LoadCSV<Player>();
            default:
                throw new ArgumentOutOfRangeException("File type not supported.");
        }
    }

    private List<HighScore>? LoadHighScores()
    {
        switch (FileType)
        {
            case FileType.json:
                return LoadJson<HighScore>();
            case FileType.xml:
                return LoadXML<HighScore>();
            case FileType.csv:
                return LoadCSV<HighScore>();
            default:
                throw new ArgumentOutOfRangeException("File type not supported.");
        }
    }

    private List<T>? LoadJson<T>()
    {
        string filePath = "D:\\Coding\\EKE\\2APEC\\INF-Birkner\\HighScoreDev\\HighScoreDAL\\HighScore\\Json\\Games.json";
        string content = File.ReadAllText(filePath);
        
        if (typeof(T) == typeof(Game))
            return JsonSerializer.Deserialize<List<Game>>(content) as List<T>;
        else if (typeof(T) == typeof(Player))
            return JsonSerializer.Deserialize<List<Player>>(content) as List<T>;
        else if (typeof(T) == typeof(HighScore))
            return JsonSerializer.Deserialize<List<HighScore>>(content) as List<T>;
        else
            throw new NotSupportedException("Type not supported.");
    }

    private List<T>? LoadCSV<T>()
    {
        if (typeof(T) == typeof(Game))
            return new List<Game>() as List<T>;
        else if (typeof(T) == typeof(Player))
            return new List<Player>() as List<T>;
        else if (typeof(T) == typeof(HighScore))
            return new List<HighScore>() as List<T>;
        else
            throw new NotSupportedException("Type not supported.");
    }

    private List<T>? LoadXML<T>()
    {
        if (typeof(T) == typeof(Game))
            return new List<Game>() as List<T>;
        else if (typeof(T) == typeof(Player))
            return new List<Player>() as List<T>;
        else if (typeof(T) == typeof(HighScore))
            return new List<HighScore>() as List<T>;
        else
            throw new NotSupportedException("Type not supported.");
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
