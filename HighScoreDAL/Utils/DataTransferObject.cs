﻿using HighScoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScoreDAL.Utils;

/// <summary>
/// Data transfer object for saving all data to one file.
/// </summary>
public class DataTransferObject
{
    public List<Game> Games { get; set; } = new List<Game>();
    public List<Player> Players { get; set; } = new List<Player>();
    public List<HighScore> HighScores { get; set; } = new List<HighScore>();
}
