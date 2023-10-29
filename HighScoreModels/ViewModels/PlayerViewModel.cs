using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels.ViewModels;

/// <summary>
/// This ViewModel includes data for a player that is relevant for the view.
/// </summary>
public class PlayerViewModel
{
    public int PlayerId { get; set; }
    public string Nickname { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
}
