using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI killsText;

    public Health[] enemiesHealth;
    private int score = 0;
    private int scoreIncrement = 15; // Score increment to trigger difficulty increase
    private int difficulty = 1; // Initial difficulty level
    private float scoreAccumulator = 0f; // Accumulates time to track score increment
    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("Kills", 0);
    }

    void Update()
    {
        UpdateKillsText();
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            scoreAccumulator += Time.deltaTime;

            if (scoreAccumulator >= 1f)
            {
                score += 1 * difficulty;
                scoreAccumulator -= 1f;

                UpdateScoreText();

                if (score % (scoreIncrement) == 0)
                {
                    IncreaseDifficulty();
                }
            }
        }
        else
        {
            PlayerPrefs.SetFloat("Player Score", score);
        }
    }

    public void UpdateKillsText()
    {
        killsText.text = "Kills: " + PlayerPrefs.GetInt("Kills").ToString();
    }

    private void UpdateScoreText()
    {
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
