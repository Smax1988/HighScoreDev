using HighScoreDAL.Utils;

namespace HighScoreBL.Repos;

/// <summary>
/// Base Repository includes the instance of the data access layer for all deriving repositories.
/// </summary>
public class BaseRepository
{
    protected readonly IHighScoreDataBase _data;

    public BaseRepository(IHighScoreDataBase data) { _data = data; }
}
