using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pulsar : MonoBehaviour
{
    private Button btn;
    public Image img;
    public Sprite[] spNumeros;
    private bool contar;
    private int numero;
    public Text cuentaAtras;
    // Start is called before the first frame update
    void Start()
    {
        //btn = GameObject.FindAnyObjectByType<Button>(); //devuelve lista con todos los elementos
        btn = GameObject.FindWithTag("btnPulsar").GetComponent<Button>();   //versión mediante etiquetas
        btn.onClick.AddListener(Pulsado);
        contar = false;
        numero = 3;
    }

    void Pulsado()
    {
        Debug.Log("Pulsado");
        img.gameObject.SetActive(true);
        cuentaAtras.gameObject.SetActive(true); //activar el texto oculto
        btn.gameObject.SetActive(false);
        contar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (contar)
        {
            switch(numero)
            {
                case 0:
                    Debug.Log("Terminado - salto a otra escena");
                    break;
                case 1:
                    img.sprite = spNumeros[0];
                    cuentaAtras.text = "1";
                    break;
                case 2:
                    img.sprite = spNumeros[1];
                    cuentaAtras.text = "2";
                    break;
                case 3:
                    img.sprite = spNumeros[2];
                    cuentaAtras.text = "3";
                    break;
            }
            StartCoroutine(Esperar());
            contar = false;
            numero--;
        }
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(1);
        contar = true;
    }
}
