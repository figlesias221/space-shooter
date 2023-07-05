using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemy2 : MonoBehaviour
{
    public Cooldown reload;
    public Transform bulletAttachPoint;
    public GameObject bulletPrefab;
    public AudioSource audioSource;
    public AudioClip clip;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

    private void FixedUpdate()
    {
        reload.current += Time.deltaTime;

        if (reload.isReady)
        {
            StartCoroutine(FireBurstCoroutine());
            reload.StartCooldown();
        }
    }

    private IEnumerator FireBurstCoroutine()
    {
        for (int i = 0; i < 3; i++) // Change the desired burst count here
        {
            FireBullet();
            yield return new WaitForSeconds(0.2f); // Adjust the delay between each bullet firing
        }
    }

    private void FireBullet()
    {
        var bulletObject = Instantiate(bulletPrefab, bulletAttachPoint.position, bulletAttachPoint.rotation);
        bulletObject.GetComponent<BulletEnemy1>().Fire();
        audioSource.Play();
    }
}

