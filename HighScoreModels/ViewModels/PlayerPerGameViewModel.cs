using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels.ViewModels;

/// <summary>
/// This ViewModel includes data for a player and a certain game that is relevant for the view.
/// </summary>
public class PlayerPerGameViewModel : PlayerViewModel
{
    public int GameId { get; set; }
    public string GameTitle {  get; set; } = string.Empty;
}
