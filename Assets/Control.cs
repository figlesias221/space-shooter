using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    private Movimiento movimiento;
    public WeaponPlayer weapon;

    private void Update()
    {
        movimiento.direction.x = Input.GetAxis("Horizontal");
        movimiento.direction.y = Input.GetAxis("Vertical");
        weapon.isTriggerPressed = Input.GetButton("Fire1");
    }
}
