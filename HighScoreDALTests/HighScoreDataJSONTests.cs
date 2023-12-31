﻿using HighScoreDAL;
using HighScoreDAL.Utils;
using HighScoreModels;

namespace HighScoreDALTests
{
    [TestFixture]
    internal class HighScoreDataJSONTests
    {
        HighScoreDataJSON data = new HighScoreDataJSON { FileType = FileType.json };

        [Test]
        public void LoadGamesFromJson_Test()
        {
            Assert.Multiple(() =>
            {
                Assert.That(data.Games, Is.Not.Null.Or.Empty);
            });
        }

        [Test]
        public void LoadPlayersFromJson()
        {
            Assert.Multiple(() =>
            {
                Assert.That(data.Players, Is.Not.Null.Or.Empty);
            });
        }

        [Test]
        public void LoadHighscoresFromJson()
        {
            Assert.Multiple(() =>
            {
                Assert.That(data.HighScores, Is.Not.Null.Or.Empty);
            });
        }

        [Test]
        public async Task SaveJsonTest()
        {
            Player player = new Player
            {
                PlayerId = 1,
                Nickname = "Player1",
                Email = "player1@example.com",
                Birthday = DateTime.Now,
                FirstName = "John",
                LastName = "Doe",
                Entry = DateTime.Now,
                Exit = DateTime.Now,
                IsActive = true,
                Notes = "Notes1"
            };

            Game game = new Game
            {
                GameId = 1,
                Title = "Title1",
                Published = DateTime.Now,
                Publisher = "Publisher1",
                Entry = DateTime.Now,
                Exit = DateTime.Now,
                IsActive = true,
                Notes = "Notes1"
            };

            HighScore highscore = new HighScore
            {
                GameId =  1,
                PlayerId = 101,
                Score =  100,
                ScoreDate =  DateTime.Now
            };

            data.Players.Add(player);
            data.Games.Add(game);
            data.HighScores.Add(highscore);

            await data.SaveAsync();
        }
    }
}
