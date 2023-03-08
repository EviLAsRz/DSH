using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tratamientoImpacto : MonoBehaviour
{

    Image barraVida;
    float vidaRestante;
   public void heSidoTocadoInside()
    {
        barraVida = this.transform.GetChild(0).GetChild(0).GetComponent<Image>();
        vidaRestante = GetComponent<gestorDeVidas>().Vida / GetComponent<gestorDeVidas>().MaxVida;
        barraVida.transform.localScale = new Vector3(vidaRestante, 1, 1);
    }
    
    public void estoyMuertoInside()
    {
        Destroy(gameObject);
    }
}
