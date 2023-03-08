using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gestorDeVidas : MonoBehaviour
{
    public float Vida = 5.0f;
    public float MaxVida = 5.0f;

    public UnityEvent heSidoTocado;
    public UnityEvent estoyMuerto;
    void tocado(float fuerza)
    {
        //tratamiento de la colision de la bala con un 
        Vida -= fuerza;
        heSidoTocado.Invoke();
        if (Vida <= 0)
        {
            estoyMuerto.Invoke();
            //destruir enemigo
        }

    }
}
