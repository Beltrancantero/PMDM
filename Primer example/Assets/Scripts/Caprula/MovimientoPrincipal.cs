using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPrincipal : MonoBehaviour
{

    CharacterController characterController;

    public float f_velocitat_rotacio = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3_velocitat_total = Vector3.zero;

        foreach (IVelocitat velocitat in GetComponents<IVelocitat>())
        {
            v3_velocitat_total += velocitat.Velocitat();
        }

        characterController.Move(v3_velocitat_total * Time.deltaTime);

        Vector3 v3_rotacio = Vector3.zero;
        foreach (IRotacio rotacio in GetComponents<IRotacio>())
        {                                                                                                                                                                                                                                                                                               
            v3_rotacio += rotacio.Rotacio();
        }
        transform.Rotate(v3_rotacio * f_velocitat_rotacio);
    }
}
