using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseMenu : MonoBehaviour
{
    public GameObject canvasObject;

    public void OnClose()
    {
        Time.timeScale = 1;
        canvasObject.SetActive(false);
    }

    public void OnMainMenu()
    {
        Time.timeScale = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void Open()
    {
        canvasObject.SetActive(true);
        Time.timeScale = 0;
    }
}

