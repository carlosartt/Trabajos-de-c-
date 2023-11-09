using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostItem : MonoBehaviour
{
    private EfectoSonoros misSonidos;
    private Animator MiAnimador;
    private bool itemRecogido = false;
    private float velocidadOriginal;

    private controlador_jugador jugadorController;

    // Start is called before the first frame update
    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
        MiAnimador = GetComponent<Animator>();

        jugadorController = GetComponentInParent<controlador_jugador>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            itemRecogido = true;
            print(otro.name + " recogio " + name);
            Personaje elPerso = otro.GetComponent<Personaje>();
            misSonidos.reproducir("aceleracion");

            velocidadOriginal = jugadorController.velocidadCaminar;

            jugadorController.duplicarVelocidad();
            MiAnimador.SetTrigger("destroy");
            Destroy(gameObject, 3f);

        }



    }

    private void OnDestroy()
    {
        if (itemRecogido)
        {
            // Restaura la velocidad original del jugador
            jugadorController.velocidadCaminar = velocidadOriginal;
        }
    }

}