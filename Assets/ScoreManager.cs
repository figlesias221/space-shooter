using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public Health[] enemiesHealth;
    private int kills = 0;
    private int scoreIncrement = 5; // Score increment to trigger difficulty increase
    private int difficulty = 1; // Initial difficulty level
    private void Start()
    {
        scoreText.text = "Score: " + GeneralScore.Score.ToString();
        PlayerPrefs.SetInt("Kills", 0);
    }

    void Update()
    {
        UpdateScore();
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (GeneralScore.Score + 1 % (scoreIncrement) == 0)
            {
                IncreaseDifficulty();
            }
        }
        else
        {
            PlayerPrefs.SetFloat("Player Score", GeneralScore.Score);
        }
    }

    private void UpdateScore()
    {
        int oldKills = kills;
        kills = PlayerPrefs.GetInt("Kills");
        if (kills > oldKills)
        {
            GeneralScore.Score += 1;
            scoreText.text = "Score: " + GeneralScore.Score.ToString();
        }
    }

    public void IncreaseScoreStar()
    {
        GeneralScore.Score += 3; ;
        scoreText.text = "Score: " + GeneralScore.Score.ToString();
    }

    private void IncreaseDifficulty()
    {
        difficulty++;
        foreach (var enemyHealth in enemiesHealth)
        {
            enemyHealth.total += 1f;
            enemyHealth.current = enemyHealth.total;
        }
    }
}
