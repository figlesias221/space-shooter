
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GamePauseMenu pauseMenu;
    public GameObject gameOverMenu;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] HighScoreHandler highScoreHandler;
    [SerializeField] string playerName;
    private bool gameOver;

    void Start()
    {
        this.gameOver = false;
    }

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void OnPauseButton()
    {
        pauseMenu.Open();
    }
    private void Update()
    {
        if (!gameOver)
        {
            if (GameObject.FindWithTag("Player") == null)
            {
                if (PlayerName.Name == "" || PlayerName.Name == null)
                {
                    playerName = "player1";
                }
                else
                {
                    playerName = PlayerName.Name;
                }

                highScoreHandler.AddHighScoreIfPossible(new HighScoreElement(playerName, scoreManager.Points));
                gameOverMenu.SetActive(true);
                Time.timeScale = 0;
                gameOver = true;
            }
        }
    }

}