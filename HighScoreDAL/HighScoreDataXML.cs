using HighScoreDAL.Utils;
using HighScoreModels;
using System.Xml;
using System.Xml.Serialization;

namespace HighScoreDAL;

/// <summary>
/// Provides saving and loading data to the file database in xml format.
/// </summary>
public class HighScoreDataXML : HighScoreDataBase
{
    /// <summary>
    /// Async method to save all data to the file database in xml format.
    /// </summary>
    /// <returns>Number of entries saved.</returns>
    public override async Task<int> SaveAsync()
    {
        DataTransferObject dto = new DataTransferObject();
        dto.Players = Players;
        dto.Games = Games;
        dto.HighScores = HighScores;
        //DEBUG dto.Players.Add(new Player { FirstName = "Test_Player", LastName = "Test_Player", PlayerId = 100000, Notes = "NEUEUEUEUEUEUEUEUEUE", Nickname = "TEST", Email = "TEST" });

        XmlSerializer serializer = new XmlSerializer(typeof(DataTransferObject));
        using (var writer = new StreamWriter(FilePath + "data.xml"))
        {
            serializer.Serialize(writer, dto);
        }
        return (_games is null ? 0 : _games.Count) +
               (_players is null ? 0 : _players.Count) +
               (_highScores is null ? 0 : _highScores.Count);
    }

    /// <summary>
    /// Loads all data for games from xml file database
    /// </summary>
    /// <returns>All game data.</returns>
    protected override List<Game> LoadGames()
    {
        return LoadXml<Game>();
    }

    /// <summary>
    /// Loads all data for highscore from xml file database.
    /// </summary>
    /// <returns>All highscore data.</returns>
    protected override List<HighScore> LoadHighScores()
    {
        return LoadXml<HighScore>();
    }

    /// <summary>
    /// Loads all data for players from xml file database.
    /// </summary>
    /// <returns>All player data.</returns>
    protected override List<Player> LoadPlayers()
    {
        return LoadXml<Player>();
    }

    /// <summary>
    /// Loads all data from xml file database.
    /// </summary>
    /// <returns>All data as xml string.</returns>
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
            XmlNodeList gameNodes = xmlDoc.SelectNodes("//Games/Game")!;

            foreach (XmlNode gameNode in gameNodes)
            {
                ParseGames(games, gameNode);
            }
            return games as List<T> ?? new List<T>();
        }
        else if (typeof(T) == typeof(Player))
        {
            List<Player> players = new List<Player>();
            XmlNodeList playerNodes = xmlDoc.SelectNodes("//Players/Player")!;

            foreach (XmlNode playerNode in playerNodes)
            {
                ParsePlayers(players, playerNode);
            }
            return players as List<T> ?? new List<T>();
        }
        else if (typeof(T) == typeof(HighScore))
        {
            List<HighScore> highscores = new List<HighScore>();
            XmlNodeList highscoreNodes = xmlDoc.SelectNodes("//HighScores/HighScore")!;

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

    /// <summary>
    /// Parses the values from xml to HighScore object and adds it to List<HighScore>
    /// </summary>
    /// <param name="highscores">Where parsed information is stored.</param>
    /// <param name="highscoreNode">xml entry that will be parsed.</param>
    private static void ParseHighscores(List<HighScore> highscores, XmlNode highscoreNode)
    {
        HighScore highscore = new HighScore();
        highscore.GameId = Convert.ToInt32(highscoreNode.SelectSingleNode("GameId")?.InnerText);
        highscore.PlayerId = Convert.ToInt32(highscoreNode.SelectSingleNode("PlayerId")?.InnerText);
        highscore.Score = Convert.ToInt32(highscoreNode.SelectSingleNode("Score")?.InnerText);
        highscore.ScoreDate = DateTime.Parse(highscoreNode.SelectSingleNode("ScoreDate")!.InnerText);

        highscores.Add(highscore);
    }

    /// <summary>
    /// Parses the values from xml to Player object and adds it to List<Player>
    /// </summary>
    /// <param name="players">Where parsed information is stored.</param>
    /// <param name="playerNode">xml entry that will be parsed.</param>
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


    /// <summary>
    /// Parses the values from xml to Game object and adds it to List<Game>
    /// </summary>
    /// <param name="games">Where parsed information is stored.</param>
    /// <param name="gameNode">xml entry that will be parsed</param>
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
}
