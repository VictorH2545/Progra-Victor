using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoNavegacion : MonoBehaviour
{
    public GameObject jugador;
    private NavMeshAgent fantasmaAgent;

    void Start()
    {
        fantasmaAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        fantasmaAgent.destination = jugador.transform.position;
    }
}
