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
        WeaponType.TripleShoot = false;
    }

    private void FixedUpdate()
    {
        reload.current += Time.deltaTime;

        if (reload.isReady && isTriggerPressed)
        {
            var bulletObject = GameObject.Instantiate(bulletPrefab, bulletAttachPoint.position, bulletAttachPoint.rotation);


            bulletObject.GetComponent<BulletPlayer>().Fire();

            if (WeaponType.TripleShoot) { 
                var bulletObject2 = GameObject.Instantiate(bulletPrefab, bulletAttachPoint.position, Quaternion.Euler(0, 0, 30));
                var bulletObject3 = GameObject.Instantiate(bulletPrefab, bulletAttachPoint.position, Quaternion.Euler(0, 0, -30));
                bulletObject2.GetComponent<BulletPlayer>().Fire();
                bulletObject3.GetComponent<BulletPlayer>().Fire();
            }
            audioSource.Play();
            reload.Reset();
        }
    }

    public void decreaseReload()
    {
        reload.current -= 0.5f;
    }

    public void ChangeWeapon()
    {
        bulletPrefab = missilePrefab;
    }
}
