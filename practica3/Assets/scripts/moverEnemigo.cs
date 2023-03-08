using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverEnemigo : MonoBehaviour
{
    Transform jugador;
    UnityEngine.AI.NavMeshAgent pathfinder;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("jugador").transform;
        pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        pathfinder.SetDestination(jugador.position);
    }
}
