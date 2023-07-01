using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI killsText;
    public string playerName;
    [SerializeField] HighScoreHandler highScoreHandler;

    public void Start()
    {
        string playerScore = PlayerPrefs.GetFloat("Player Score").ToString();
        string playerKills = PlayerPrefs.GetInt("Kills").ToString();
        scoreText.text = "Score: " + playerScore;
        killsText.text = "Kills: " + playerKills; 
    }

    public void OnMainMenu()
    {
        if (PlayerName.Name == "" || PlayerName.Name == null)
        {
            playerName = "player1";
        }
        else
        {
            playerName = PlayerName.Name;
        }

        highScoreHandler.AddHighScoreIfPossible(new HighScoreElement(playerName, Mathf.RoundToInt(PlayerPrefs.GetFloat("Player Score"))));

        SceneManager.LoadScene("MainMenu");
    }

    public void ReadInput(string input)
    {
        playerName = input;
        PlayerName.Name = playerName; 
    }
}
