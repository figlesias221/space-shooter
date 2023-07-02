using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissilePickupSpawn : MonoBehaviour
{
    public GameObject missilePickup;
    public float maxX;
    public float minX;

    public bool isPickupCollected = false;

    private void Start()
    {
        StartCoroutine(SpawnPickups());
    }

    private IEnumerator SpawnPickups()
    {
        while (true)
        {
            if (!isPickupCollected)
            {
                yield return new WaitForSeconds(30f);

                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(0, 1);

                Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

                Instantiate(missilePickup, transform.position + spawnPosition, transform.rotation);
            }
            else
            {
                yield return null;
            }
        }
    }

    public void SetPickupCollected(bool collected)
    {
        isPickupCollected = collected;
    }
}
