using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupElem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Health pickup collected");
            GameObject.Destroy(gameObject);
            collision.gameObject.GetComponent<PlayerHealth>().IncreaseLife();
        }
    }
}
