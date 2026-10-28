using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    public float speed = 10f;
    // velocidad vertical mantenida entre frames
    private Vector3 v3_velocitat_vertical = Vector3.zero;

    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 v3_direccion = Vector3.zero;

        if (Keyboard.current.wKey.isPressed /*|| Gamepad.current.leftStick.up.isPressed*/)
        {
            v3_direccion += Vector3.forward;
        }
        if (Keyboard.current.sKey.isPressed /*|| Gamepad.current.leftStick.down.isPressed*/)
        {
            v3_direccion += Vector3.back;
        }
        if (Keyboard.current.aKey.isPressed /*|| Gamepad.current.leftStick.left.isPressed*/)
        {
            v3_direccion += Vector3.left;
        }
        if (Keyboard.current.dKey.isPressed /*|| Gamepad.current.leftStick.right.isPressed */)
        {
            v3_direccion += Vector3.right;
        }
        if (Keyboard.current.spaceKey.isPressed)
        {
            // salto instantáneo (puedes cambiar a un valor de salto distinto)
            v3_velocitat_vertical.y = speed;
        }

        // gravedad aplicada cada frame
        v3_velocitat_vertical += Physics.gravity * Time.deltaTime;

        // Separar componente horizontal y vertical al mover
        Vector3 horizontal = v3_direccion.normalized * speed * (Keyboard.current.leftCtrlKey.isPressed ? 5 : 1);

        characterController.Move((horizontal + v3_velocitat_vertical) * Time.deltaTime);
    }
}
