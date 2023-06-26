using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void OnHighScores()
    {
        SceneManager.LoadScene("HighScores");
    }
}
