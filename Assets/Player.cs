using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public WeaponPlayer weaponPlayer;
    public MissilePickupSpawn missilePickupSpawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))
        {
            if (missilePickupSpawn.isPickupCollected)
            {
                weaponPlayer.decreaseReload();
            }
            else
            {
                weaponPlayer.ChangeWeapon();
                missilePickupSpawn.SetPickupCollected(true);
            }
            Destroy(collision.gameObject);
        }
    }
}
