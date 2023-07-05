using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy1 : MonoBehaviour
{
    public float speed;

    public int minDamage, maxDamage;
    public Cooldown fireCooldown;

    public Cooldown timeToLive;
    public int burstCount = 3;
    public void Fire()
    {
        var body = GetComponent<Rigidbody2D>();
        body.AddForce(-transform.up * speed, ForceMode2D.Impulse);
    }

    public void FireBurst()
    {
        if (fireCooldown.isReady)
        {
            StartCoroutine(FireBurstCoroutine());
            fireCooldown.StartCooldown();
        }
    }

    private IEnumerator FireBurstCoroutine()
    {
        for (int i = 0; i < burstCount; i++)
        {
            Fire();
            yield return new WaitForSeconds(0.2f); // Adjust the delay between each bullet firing
        }
    }


    private void FixedUpdate()
    {
        timeToLive.current += Time.deltaTime;

        if (timeToLive.isReady)
        {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        var playerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage();
        }
        GameObject.Destroy(gameObject);
    }
}
