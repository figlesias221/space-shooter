
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GamePauseMenu pauseMenu;
    public GameObject gameOverMenu;

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
        if (GameObject.FindWithTag("Player") == null)
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

}