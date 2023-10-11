using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels;

public class HighScore
{
    public int GameId { get; set; }
    public int PlayerId { get; set; }
    public int Score { get; set; }
    public DateTime ScoreDate { get; set; }
}
