using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreModels.ViewModels
{
    public class PlayerPerGameViewModel
    {
        public int PlayerId { get; set; }
        public string Nickname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
