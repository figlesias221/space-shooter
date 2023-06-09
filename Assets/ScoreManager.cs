using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private int scoreIncrement = 15; // Score increment to trigger difficulty increase
    private int difficulty = 1; // Initial difficulty level

    private float scoreAccumulator = 0f; // Accumulates time to track score increment

    private void Start()
    {
        scoreText.text = score.ToString(); // Set initial score text
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            // Accumulate time for score increment
            scoreAccumulator += Time.deltaTime;

            // Check if the score increment condition is met
            if (scoreAccumulator >= 1f) // Increase score every 1 second
            {
                // Increase the score based on difficulty level
                score += 1 * difficulty;
                scoreAccumulator -= 1f; // Reset the score accumulator

                UpdateScoreText();

                // Check if the score has reached a multiple of the score increment
                if (score % (scoreIncrement) == 0) // Increase difficulty every 10 score increments
                {
                    IncreaseDifficulty();
                }
            }
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    private void IncreaseDifficulty()
    {
        difficulty++;
    }
}
