using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public void OnBack()
    {
        // Load the "MainMenu" scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
