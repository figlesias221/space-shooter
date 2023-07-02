
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GamePauseMenu pauseMenu;
    public GameObject gameOverMenu;
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
                gameOverMenu.SetActive(true);
                Time.timeScale = 0;
                gameOver = true;
            }
        }
    }

}