using UnityEngine;
using UnityEngine.InputSystem;

public class Velocitat_Caminar : MonoBehaviour, IVelocitat
{
    CharacterController characterController;
    public float f_velocitat = 10f;
    Vector3 v3_l_velocitat = Vector3.zero;
    public Vector3 Velocitat()
    {
        

        if (characterController.isGrounded)
        {
            v3_l_velocitat = Vector3.zero;

            if (Keyboard.current.wKey.isPressed /*|| Gamepad.current.leftStick.up.isPressed*/)
            {
                v3_l_velocitat += Vector3.forward;
            }
            if (Keyboard.current.sKey.isPressed /*|| Gamepad.current.leftStick.down.isPressed*/)
            {
                v3_l_velocitat += Vector3.back;
            }
            if (Keyboard.current.aKey.isPressed /*|| Gamepad.current.leftStick.left.isPressed*/)
            {
                v3_l_velocitat += Vector3.left;
            }
            if (Keyboard.current.dKey.isPressed /*|| Gamepad.current.leftStick.right.isPressed */)
            {
                v3_l_velocitat += Vector3.right;
            }
            
        }

        return transform.TransformDirection(v3_l_velocitat.normalized * f_velocitat);
    }

    void Start()
    {
        
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
    
    }
}