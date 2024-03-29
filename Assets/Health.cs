using System;
using Cinemachine;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float current;
    public float total;

    // public GameObject deathFxPrefab;

    // public CinemachineImpulseSource deathImpulseSource;

    public float factor => current / total;

    // public UnityEvent<float> onDamageUnityEvent;

    public void Damage(float damage)
    {
        current -= damage;

        if (damage > 0)
        {
            // onDamageUnityEvent.Invoke(damage);
            // gameObject.BroadcastMessage("OnDamage", damage, SendMessageOptions.DontRequireReceiver);

            // EventosGenerales.OnPersonajeDamaged(this.gameObject, damage);
        }

        if (current <= 0)
        {
            // if (deathImpulseSource != null)
            // {
            //     deathImpulseSource.GenerateImpulse();
            // }

            // EventosGenerales.OnPersonajeDeath(this.gameObject, damage);

            // GameObject.Instantiate(deathFxPrefab, transform.position, transform.rotation);

            GameObject.Destroy(gameObject);
            return;
        }
    }

}