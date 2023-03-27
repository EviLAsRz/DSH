using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cambioPantalla : MonoBehaviour
{
    public string nombreEscena;
    public Text texto;
    int contador;
    // Start is called before the first frame update
    void Start()
    {
        //contador = PlayerPrefs.GetInt("contador");
        contador = controlMusica.dameContador();
        controlMusica.addContador();
        texto.text = contador.ToString();
        //contador++;
        //PlayerPrefs.SetInt("contador", contador);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
