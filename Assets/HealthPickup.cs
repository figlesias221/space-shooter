using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HealthPickup : MonoBehaviour
{
    public GameObject healthPickup;
    public float spawnInterval = 14f;

    public float maxX;
    public float minX;

    private void Start()
    {
        StartCoroutine(SpawnPickups());
    }

    private IEnumerator SpawnPickups()
    {
        while (true)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(0, 1);

            Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

            yield return new WaitForSeconds(spawnInterval);
            Instantiate(healthPickup, transform.position + spawnPosition, transform.rotation);
        }
    }
}
