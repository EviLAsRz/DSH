using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acciones : MonoBehaviour
{

    //Animator animacion;
    Rigidbody rb;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movHorizontal, 0.0f, movVertical);
        rb.AddForce(movement * movementSpeed);

        /*
        if (movement.magnitude > 0.0f)
        {
            animacion.SetBool("andar", true);
        }
        else
            animacion.SetBool("andar", false);

        */
    }
}
