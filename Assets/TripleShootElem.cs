using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShootElem : MonoBehaviour
{
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Destroy(gameObject);
            WeaponType.TripleShoot = true;
            AudioSource.PlayClipAtPoint(audioClip, transform.position, 1.0F);
        }
    }
}
