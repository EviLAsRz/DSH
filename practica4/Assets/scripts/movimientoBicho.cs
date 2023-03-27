using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBicho : MonoBehaviour
{
    Animator animacion;
    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animacion.SetBool("andar", true);
        }
    }
}
