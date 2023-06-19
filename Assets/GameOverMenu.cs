using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI killsText;

    public void Start()
    {
        string playerScore = PlayerPrefs.GetFloat("Player Score").ToString();
        string playerKills = PlayerPrefs.GetInt("Kills").ToString();
        scoreText.text = "Score: " + playerScore;
        killsText.text = "Kills: " + playerKills;

    }
    public void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
