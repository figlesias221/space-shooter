using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public string playerName;
    [SerializeField] HighScoreHandler highScoreHandler;

    public void Start()
    {
        string playerScore = GeneralScore.Score.ToString();
        scoreText.text = "Score: " + playerScore;
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

        highScoreHandler.AddHighScoreIfPossible(new HighScoreElement(playerName, Mathf.RoundToInt(GeneralScore.Score)));

        SceneManager.LoadScene("MainMenu");
    }

    public void ReadInput(string input)
    {
        playerName = input;
        PlayerName.Name = playerName;
    }
}
