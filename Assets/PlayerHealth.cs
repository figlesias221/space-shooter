using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxLives = 3;
    public Image[] lifeImages;
    public float invincibilityDuration = 3f;
    public float blinkInterval = 0.2f;
    public float shakeDuration = 0.3f;
    public float shakeMagnitude = 0.1f;

    private int currentLives;
    private bool isInvincible = false;
    private SpriteRenderer spriteRenderer;
    private Transform mainCameraTransform;
    public Vector3 cameraInitialPosition;

    public GameObject gameOverMenu;

    private void Start()
    {
        currentLives = maxLives;
        spriteRenderer = GetComponent<SpriteRenderer>();
        mainCameraTransform = Camera.main.transform;
        cameraInitialPosition = mainCameraTransform.position;
    }

    public void TakeDamage()
    {
        if (!isInvincible && currentLives > 0)
        {
            currentLives--;
            UpdateLifeImages();

            if (currentLives == 0)
            {
                GameOver();
            }
            else
            {
                StartCoroutine(InvincibilityCoroutine());
                StartCoroutine(ShakeCameraCoroutine());
            }
        }
    }

    private IEnumerator InvincibilityCoroutine()
    {
        isInvincible = true;
        float endTime = Time.time + invincibilityDuration;

        while (Time.time < endTime)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;

            yield return new WaitForSeconds(blinkInterval);
        }

        spriteRenderer.enabled = true;
        isInvincible = false;
    }

    private IEnumerator ShakeCameraCoroutine()
    {
        float endTime = Time.time + shakeDuration;
        Vector3 originalCameraLocalPosition = mainCameraTransform.localPosition;
        Vector3 offset = Vector3.zero;

        while (Time.time < endTime)
        {
            float randomX = Random.Range(-1f, 1f) * shakeMagnitude;
            float randomY = Random.Range(-1f, 1f) * shakeMagnitude;

            offset = new Vector3(randomX, randomY, 0f);
            mainCameraTransform.localPosition = originalCameraLocalPosition + offset;

            yield return null;
        }

        mainCameraTransform.localPosition = originalCameraLocalPosition;
    }

    public void IncreaseLife()
    {
        if (currentLives < maxLives)
        {
            currentLives++;
            UpdateLifeImages();
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
        Destroy(gameObject);
    }
}
