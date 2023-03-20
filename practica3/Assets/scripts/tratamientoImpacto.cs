using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tratamientoImpacto : MonoBehaviour
{

    Image barraVida;
    float vidaRestante;

    public delegate void OnDeath();
    public static event OnDeath OnDeathEnemigo;
    sonidoHit hitSound = new sonidoHit();   //declaración de la clase para utilizar sus métodos.
    public void heSidoTocadoInside()
    {
        barraVida = this.transform.GetChild(0).GetChild(0).GetComponent<Image>();
        vidaRestante = GetComponent<gestorDeVidas>().Vida / GetComponent<gestorDeVidas>().MaxVida;
        barraVida.transform.localScale = new Vector3(vidaRestante, 1, 1);
        hitSound.playSound();   //cuando el enemigo es golpeado, se reproduce el sonido.
    }
    
    public void estoyMuertoInside()
    {
        if (OnDeathEnemigo != null)
            OnDeathEnemigo();

        Destroy(gameObject);
    }
}
