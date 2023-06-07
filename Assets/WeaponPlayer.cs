using UnityEngine;
using System.Collections;

public class WeaponPlayer : MonoBehaviour
{
    public bool isTriggerPressed;

    public Cooldown reload;

    // public Transform pivot;
    public Transform bulletAttachPoint;

    public GameObject bulletPrefab;
    // public SpriteRenderer spriteRenderer;


    private void FixedUpdate()
    {
        reload.current += Time.deltaTime;

        if (reload.isReady && isTriggerPressed)
        {
            var bulletObject = GameObject.Instantiate(bulletPrefab, bulletAttachPoint.position, bulletAttachPoint.rotation);
            bulletObject.GetComponent<BulletPlayer>().Fire();
            reload.Reset();
        }
    }

    // public void SetWeapon(Weapon weapon)
    // {
    //     reload = weapon.reload;
    //     bulletPrefab = weapon.bulletPrefab;
    //     bulletFxPrefab = weapon.bulletFxPrefab;
    //     spriteRenderer.sprite = weapon.spriteRenderer.sprite;
    // }
}
