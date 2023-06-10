using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    public Image[] lifeImages;

    private int currentLives;
    public GameObject gameOverMenu;
    private void Start()
    {
        currentLives = maxLives;
    }

    public void TakeDamage()
    {
        if (currentLives > 0)
        {
            currentLives--;
            UpdateLifeImages();

            if (currentLives == 0)
            {
                // Player loses, handle game over logic here
                GameOver();
            }
        }
    }

    private void UpdateLifeImages()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (i < currentLives)
                lifeImages[i].enabled = true;
            else
                lifeImages[i].enabled = false;
        }
    }

    private void GameOver()
    {
        // destroy player
        Destroy(gameObject);
    }
}
