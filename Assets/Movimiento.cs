using System;
using UnityEngine;


public class Movimiento : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
   	 
    [NonSerialized]
    public Vector3 direccion;
    
    void FixedUpdate()
    {
        transform.position += direccion * speed * Time.deltaTime;
    }
}