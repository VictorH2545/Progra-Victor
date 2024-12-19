using Profe;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject cartelAnuncio;
    public GameObject cartelCongrats;
    public InventoryHandler inventarioJugador;
    public bool hasKey;


    private void Start()
    {
        inventarioJugador = GameObject.Find("Jugador").GetComponent<InventoryHandler>();
    }

    public void Interact()
    {
        if (inventarioJugador.inventory.Count == 6)
        {
            cartelAnuncio.SetActive(false);
            Destroy(gameObject);
            cartelCongrats.SetActive(true);
        }
    }
}
