using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HighScoreModels;

/// <summary>
/// This model represents all data for a highscore.
/// </summary>
public class HighScore
{
    public int GameId { get; set; }
    public int PlayerId { get; set; }
    public int Score { get; set; }
    public DateTime ScoreDate { get; set; }
}



