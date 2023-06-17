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

    private void Start()
    {
        StartCoroutine(SpawnPickups());
    }

    private IEnumerator SpawnPickups()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(healthPickup, transform.position, Quaternion.identity);
        }
    }
}
