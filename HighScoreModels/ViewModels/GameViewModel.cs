using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels.ViewModels;

/// <summary>
/// This ViewModel includes data for a game that is relevant for the view.
/// </summary>
public class GameViewModel
{
    public int GameId { get; set; }
    public string Title { get; set; } = string.Empty;
}
