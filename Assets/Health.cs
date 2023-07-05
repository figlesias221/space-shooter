using System;
using Cinemachine;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float current;
    public float total;
    public float factor => current / total;
    public GameObject starPrefab;

    public void Damage(float damage)
    {
        current -= damage;

        if (current <= 0)
        {
            GameObject.Destroy(gameObject);
            if (gameObject.tag == "Enemy")
            {
                Instantiate(starPrefab, transform.position, transform.rotation);
            }
            PlayerPrefs.SetInt("Kills", PlayerPrefs.GetInt("Kills") + 1);
            return;
        }
    }

}