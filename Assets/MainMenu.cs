using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // onClick event handler for the "Play" button
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
}
