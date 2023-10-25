﻿using HighScoreDAL.Utils;
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
        });
    }

    [Test]
    public async Task SaveJsonTest()
    {
        HighScoreData highscoreData = new HighScoreData();
        await highscoreData.Save();
    }

    [Test]
    public async Task SaveXmlTest()
    {
        HighScoreData highscoreData = new HighScoreData();
        highscoreData.FileType = FileType.xml;

        await highscoreData.Save();
    }
}
