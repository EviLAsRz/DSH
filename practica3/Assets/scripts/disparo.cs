using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    float proximoDisparo = 0.0f;
    float tiempoDisparo = 0.3f;

    Transform salida;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= proximoDisparo && Input.GetMouseButtonDown(0))
        {
            proximoDisparo = Time.time + tiempoDisparo;
            GameObject nuevaBala = Instantiate(bala, salida.position, salida.rotation);
        }
    }
}
