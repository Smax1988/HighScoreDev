using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels.ViewModels
{
    public class PlayerPerGameViewModel : PlayerViewModel
    {
        public int GameId { get; set; }
        public string GameTitle {  get; set; } = string.Empty;
    }
}
