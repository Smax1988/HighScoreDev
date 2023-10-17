﻿using HighScoreDAL;
using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDALTests;

[TestFixture]
internal class HighScoreDataTests
{
    [Test]
    public void LoadGamesFromJson_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.json;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Games, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.Games, Is.TypeOf<List<Game>>());
            Assert.That(highscoreData.Games.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadGamesFromXml_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.xml;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Games, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.Games, Is.TypeOf<List<Game>>());
            Assert.That(highscoreData.Games.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadGamesFromCsv_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.csv;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Games, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.Games, Is.TypeOf<List<Game>>());
            Assert.That(highscoreData.Games.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadPlayersFromJson()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.json;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Players, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.Players, Is.TypeOf<List<Player>>());
            Assert.That(highscoreData.Players.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadPlayersFromXml_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.xml;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Players, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.Players, Is.TypeOf<List<Player>>());
            Assert.That(highscoreData.Players.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadPlayersFromCsv_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.csv;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Players, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.Players, Is.TypeOf<List<Player>>());
            Assert.That(highscoreData.Players.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadHighscoresFromJson()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.json;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.HighScores, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.HighScores, Is.TypeOf<List<HighScore>>());
            Assert.That(highscoreData.HighScores.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadHighscoresFromXml_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.xml;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.HighScores, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.HighScores, Is.TypeOf<List<HighScore>>());
            Assert.That(highscoreData.HighScores.Count, Is.EqualTo(10));
        });
    }

    [Test]
    public void LoadHighscoresFromCsv_Test()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.csv;

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.HighScores, Is.Not.Null.Or.Empty);
            Assert.That(highscoreData.HighScores, Is.TypeOf<List<HighScore>>());
            Assert.That(highscoreData.HighScores.Count, Is.EqualTo(10));
        });
    }
}
