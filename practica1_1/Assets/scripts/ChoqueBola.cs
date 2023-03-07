using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueBola : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particulas;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnDestroy()
    {
        Vector3 posactual = new Vector3(transform.position.x, 0.5f, transform.position.z);
        Instantiate(particulas, posactual, particulas.transform.rotation);
        Debug.Log("Se destruye");
    }
}
