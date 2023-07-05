using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickupElem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Destroy(gameObject);
            collision.gameObject.GetComponent<ScoreManager>().IncreaseScoreStar();
        }
    }
}
