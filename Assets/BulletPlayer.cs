using System;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public float speed;
    public int minDamage, maxDamage;
    public Cooldown timeToLive;

    // public GameObject hitFxPrefab;

    public void Fire()
    {
        var body = GetComponent<Rigidbody2D>();
        body.AddForce(transform.up * speed, ForceMode2D.Impulse);
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
        var health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.Damage(UnityEngine.Random.Range(minDamage, maxDamage));
        }

        GameObject.Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.Damage(UnityEngine.Random.Range(minDamage, maxDamage));
        }

        GameObject.Destroy(gameObject);
    }
}
