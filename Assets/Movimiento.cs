using System;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;

    [NonSerialized]
    public Vector3 direction;

    void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
