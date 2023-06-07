using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    private Movimiento movimiento;

    private void Update()
    {
        movimiento.direction.x = Input.GetAxis("Horizontal");
        movimiento.direction.y = Input.GetAxis("Vertical");
    }
}
