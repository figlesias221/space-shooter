using UnityEngine;


public class Control : MonoBehaviour
{
    [SerializeField]
    private Movimiento movimiento;
   	 
    private void Update()
    {
        movimiento.direccion.x = Input.GetAxis("Horizontal");
        movimiento.direccion.y = Input.GetAxis("Vertical");
    }
}