using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilePickupSpawn : MonoBehaviour
{
    public GameObject missilePickup;


    public float maxX;
    public float minX;

    private void Start()
    {
        StartCoroutine(SpawnPickups());
    }

    private IEnumerator SpawnPickups()
    {
        yield return new WaitForSeconds(5f);

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(0, 1);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        Instantiate(missilePickup, transform.position + spawnPosition, transform.rotation);
    }
}
