using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class movimientoJugador : MonoBehaviour
{
    Animator animator;
    InputCharacter input;
    Vector2 currentMovement;
    bool pulsadoMoverse;
    bool pulsadoCorrer;

    // Start is called before the first frame update
    private void Awake()
    {
        input = new InputCharacter();
        //input.actionMovimiento.Moverse.performed += ctx => Debug.Log(ctx.ReadValueAsObject());
        input.actionMovimiento.Moverse.performed += ctx =>
        {
            currentMovement = ctx.ReadValue<Vector2>();
            pulsadoMoverse = currentMovement.x != 0 || currentMovement.y != 0;
        };

    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        handleMovement();
        handleRotate();
    }

    void handleRotate()
    {
        Vector3 currentPosition = transform.position;

        //Posicion a la que apunta el mando
        Vector3 newPosition = new Vector3(currentMovement.x, 0.0f, currentMovement.y);

        //combino ambas posiciones
        Vector3 nuevaDireccion = currentPosition + newPosition;

        //Cambio la direccion del objeto
        transform.LookAt(nuevaDireccion);
    }
    void handleMovement()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool isRunning = animator.GetBool("isRunning");

        if (isWalking && pulsadoMoverse)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !pulsadoMoverse)
        {
            animator.SetBool("isWalking", false);
        }

        if (isWalking && !isRunning && pulsadoCorrer)
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && !pulsadoCorrer)
        {
            animator.SetBool("isRunning", false);
        }
    }
}
