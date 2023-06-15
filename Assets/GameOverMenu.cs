using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void Start()
    {
        string playerScore = PlayerPrefs.GetFloat("Player Score").ToString();
        scoreText.text = "Score: " + playerScore;

    }
    public void OnMainMenu()
    {
        // Load the "MainMenu" scene
        SceneManager.LoadScene("MainMenu");
    }
}
