using UnityEngine;
using UnityEngine.InputSystem;

public class Rotacion_Jugador : MonoBehaviour, IRotacio
{

    CharacterController characterController;

    public float f_velocitat_rotacio = 1f;

    public Vector3 Rotacio()
    {

        if (characterController.isGrounded)
        {
            transform.Rotate(Vector3.up, Mouse.current.delta.ReadValue().x * f_velocitat_rotacio);
            return Vector3.up * Mouse.current.delta.ReadValue().x * f_velocitat_rotacio;
        }
        return Vector3.up * 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        characterController = GetComponent<CharacterController>();
    }
}
