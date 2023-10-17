using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HighScoreModels
{
    public class Game : Details
    {
        public int GameId { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Published { get; set; }
        public string Publisher { get; set; } = string.Empty;
    }
}
