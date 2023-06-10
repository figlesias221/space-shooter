using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEnemy1 : MonoBehaviour
{
    public Cooldown reload;
    public Transform bulletAttachPoint;
    public GameObject bulletPrefab;

    private void FixedUpdate()
    {
        reload.current += Time.deltaTime;

        if (reload.isReady)
        {
            var bulletObject = Instantiate(bulletPrefab, bulletAttachPoint.position, bulletAttachPoint.rotation);
            bulletObject.GetComponent<BulletEnemy1>().Fire();
            reload.Reset();
        }
    }
}
