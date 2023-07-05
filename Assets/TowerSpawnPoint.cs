using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawnPoint : MonoBehaviour
{
    public GameObject leftTowerPrefab;
    public GameObject rightTowerPrefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float spawnRate = 1f;

    private float nextSpawn = 0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            SpawnTower();
            nextSpawn = Time.time + spawnRate;
        }

    }

    void SpawnTower()
    {
        bool spawnAtLeft = Random.value < 0.5;
        GameObject towerPrefab = spawnAtLeft ? leftTowerPrefab : rightTowerPrefab;

        float randomX = spawnAtLeft ? minX : maxX;
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        Instantiate(towerPrefab, transform.position + spawnPosition, transform.rotation);
    }
}
