using UnityEngine;
using System.Collections;

public class WeaponPlayer : MonoBehaviour
{
    public bool isTriggerPressed;

    public Cooldown reload;

    public Transform bulletAttachPoint;

    public GameObject bulletPrefab;
    public GameObject missilePrefab;

    public AudioSource audioSource;
    public AudioClip clip;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

    private void FixedUpdate()
    {
        reload.current += Time.deltaTime;

        if (reload.isReady && isTriggerPressed)
        {
            var bulletObject = GameObject.Instantiate(bulletPrefab, bulletAttachPoint.position, bulletAttachPoint.rotation);
            bulletObject.GetComponent<BulletPlayer>().Fire();
            audioSource.Play();
            reload.Reset();
        }
    }

    public void ChangeWeapon()
    {
        bulletPrefab = missilePrefab;
    }

    // public void SetWeapon(Weapon weapon)
    // {
    //     reload = weapon.reload;
    //     bulletPrefab = weapon.bulletPrefab;
    //     bulletFxPrefab = weapon.bulletFxPrefab;
    //     spriteRenderer.sprite = weapon.spriteRenderer.sprite;
    // }
}
