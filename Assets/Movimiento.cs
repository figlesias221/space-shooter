using System;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    public Rigidbody2D rigid;

    [NonSerialized]
    public Vector3 direction;
    public float tilt;

    void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
        tilt = -direction.x;
        rigid.rotation = speed * tilt;
    }
}
