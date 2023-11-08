using HighScoreBL;

namespace HighScoreGUI;

public partial class MainFrm : Form
{
    private readonly UnitOfWork unitOfWork;

    public MainFrm()
    {
        InitializeComponent();

        unitOfWork = new UnitOfWork();

        var players = unitOfWork.PlayersRepo.GetAllPlayers();
        var games = unitOfWork.GamesRepo.GetAllGames();
        var highscoresPerPlayer = unitOfWork.HighScoresRepo.GetAllHighScoreByPlayerId(1);
        var highscoresPerGame = unitOfWork.HighScoresRepo.GetAllHighScoreByGameId(1);

        dtgPlayers.DataSource = players;
        dtgGames.DataSource = games;
        dtgHighscoresPlayer.DataSource = highscoresPerPlayer;
        dtgHighscoresGame.DataSource = highscoresPerGame;
    }
}