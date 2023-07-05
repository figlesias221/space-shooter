using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public Health[] enemiesHealth;
    private int score = 0;
    private int kills = 0;
    private int scoreIncrement = 15; // Score increment to trigger difficulty increase
    private int difficulty = 1; // Initial difficulty level
    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("Kills", 0);
    }

    void Update()
    {
        UpdateScore();
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (score + 1 % (scoreIncrement) == 0)
            {
                IncreaseDifficulty();
            }
        }
        else
        {
            PlayerPrefs.SetFloat("Player Score", score);
        }
    }

    private void UpdateScore()
    {
        int oldKills = kills;
        kills = PlayerPrefs.GetInt("Kills");
        if (kills > oldKills)
        {
            score += 1;
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void IncreaseScoreStar()
    {
        score += 3;
        scoreText.text = "Score: " + score.ToString();
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

    public int Points
    {
        get
        {
            return score;
        }
    }
}
