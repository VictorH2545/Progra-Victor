using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoExplosion : MonoBehaviour
{
    public GameObject particulas;
    public VidaJugador vidaDeJugador;

    [SerializeField] private float danio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jugador"))
        {
            Instantiate(particulas, transform.position, transform.rotation);

            vidaDeJugador.RecibirDaño(danio);

            Destroy(this.gameObject);
        }
    }
}
