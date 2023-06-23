using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    private Movimiento movimiento;
    public WeaponPlayer weapon;
    public Rigidbody2D rigid;

    public void Start()
    {
        movimiento.rigid = rigid;
    }

    private void Update()
    {
        movimiento.direction.x = Input.GetAxis("Horizontal");
        movimiento.direction.y = Input.GetAxis("Vertical");

        weapon.isTriggerPressed = Input.GetButton("Fire1") || Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.LeftControl);
    }
}
