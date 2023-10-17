using HighScoreDAL;
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
    public void LoadGamesTest()
    {
        HighScoreData highscoreData = new HighScoreData();

        Assert.Multiple(() =>
        {
            Assert.That(highscoreData.Games, Is.Not.Null);
            Assert.That(highscoreData.Games, Is.TypeOf<List<Game>>());
        });
    }
}
