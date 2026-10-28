using UnityEngine;
using UnityEngine.InputSystem;

public class Velocitat_Gravedad : MonoBehaviour , IVelocitat
{
    public float f_impuls_bot = 2f;

    public AudioSource audioSource_salto;
    CharacterController characterController;
    Vector3 v3_velocitat = Vector3.zero;
    public Vector3 Velocitat()
    {
        if (characterController.isGrounded)
        {
            v3_velocitat = Vector3.zero;
            if (Keyboard.current.spaceKey.isPressed || Mouse.current.rightButton.isPressed)
            {
                v3_velocitat += f_impuls_bot * Vector3.up;
                audioSource_salto.Play();

            }
        }

        

        v3_velocitat += Physics.gravity * Time.deltaTime;

        return v3_velocitat;
    }
   


    void Start()
    {

        
        characterController = GetComponent<CharacterController>();
        audioSource_salto = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
