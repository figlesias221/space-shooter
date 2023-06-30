using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public WeaponPlayer weaponPlayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))
        {
            weaponPlayer.ChangeWeapon();
            Destroy(collision.gameObject);
        }
    }
}
