using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBala : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 5.0f;
    public float valorHerida = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.up * movDistancia);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemigo"))
        {
            other.SendMessage("tocado", valorHerida, SendMessageOptions.DontRequireReceiver);
        }
    }
}
