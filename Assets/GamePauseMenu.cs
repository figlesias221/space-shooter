using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseMenu : MonoBehaviour
{
    public GameObject canvasObject;

    private void Awake()
    {
        canvasObject.SetActive(false);
    }

    public void OnClose()
    {
        Time.timeScale = 1;
        canvasObject.SetActive(false);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void Open()
    {
        Time.timeScale = 0;
        canvasObject.SetActive(true);
    }
}

