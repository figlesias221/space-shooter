using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    // onClick event handler for the "Main Menu" button
    public void OnMainMenu()
    {
        // Load the "MainMenu" scene
        SceneManager.LoadScene("MainMenu");
    }
}
