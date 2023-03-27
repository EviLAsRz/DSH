using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlMusica : MonoBehaviour
{
    public static controlMusica _instancia;
    public int contador;

    private void Awake()
    {
        if (controlMusica._instancia == null)
        {
            controlMusica._instancia = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
            
    }

    public static void addContador() { _instancia.contador++; }
    public static int dameContador() { return _instancia.contador; }

}
