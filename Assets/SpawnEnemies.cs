using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;

    public GameObject enemyPrefab3;

    public float maxX;
    public float minX;

    public float maxY;
    public float minY;

    public float spawnRate = 1f;

    private float nextSpawn = 0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Spawn();
            nextSpawn = Time.time + spawnRate;
        }

    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        int randomEnemy = Random.Range(0, 3);

        if (randomEnemy == 0)
        {
            Instantiate(enemyPrefab1, transform.position + spawnPosition, transform.rotation);
        }
        else if (randomEnemy == 1)
        {
            Instantiate(enemyPrefab2, transform.position + spawnPosition, transform.rotation);
        }
        else if (randomEnemy == 2)
        {
            Instantiate(enemyPrefab3, transform.position + spawnPosition, transform.rotation);
        }
    }
}
