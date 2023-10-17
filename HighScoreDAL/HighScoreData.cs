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
                return LoadJson();
            case FileType.xml:
                return LoadXML();
            case FileType.csv:
                return LoadCSV();
            default:
                throw new NotSupportedException("File type not supported.");
        }
    }

    private List<Player>? LoadPlayers()
    {
        switch (FileType)
        {
            case FileType.json:
                return LoadJson();
            case FileType.xml:
                return LoadXML();
            case FileType.csv:
                return LoadCSV();
            default:
                throw new NotSupportedException("File type not supported.");
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
                throw new NotSupportedException("File type not supported.");
        }
    }

    private List<T> LoadJson<T>()
    {
        string filePath = FilePath + "\\data.json";
        string jsonContent = File.ReadAllText(filePath);
        List<T>? result;
        
        if (typeof(T) == typeof(Game))
            result = JsonSerializer.Deserialize<List<Game>>(jsonContent) as List<T>;
        else if (typeof(T) == typeof(Player))
            result = JsonSerializer.Deserialize<List<Player>>(jsonContent) as List<T>;
        else if (typeof(T) == typeof(HighScore))
            result = JsonSerializer.Deserialize<List<HighScore>>(jsonContent) as List<T>;
        else
            throw new NotSupportedException("Type not supported.");

        return result!;
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
