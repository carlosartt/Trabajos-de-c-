using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : MonoBehaviour
{
    public int cantVidas = 1;
    public int cantDinero = 1;
    private EfectoSonoros misSonidos;
    private Animator MiAnimador;
    private bool obtenerGema = false;

    // Propiedad que indica si la gema ha sido recogida
    public bool GemaRecogida { get { return obtenerGema; } }

    // Start is called before the first frame update
    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
        MiAnimador = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            if (!obtenerGema)
            {
                print(otro.name + " toco " + name);
                Personaje elPerso = otro.GetComponent<Personaje>();
                if (elPerso != null && !obtenerGema)
                {
                    elPerso.ganarVidas(cantVidas, this.gameObject);
                    elPerso.ganarDinero(cantDinero, this.gameObject);

                    obtenerGema = true;

                    MiAnimador.SetTrigger("Desaparecer");
                    misSonidos.reproducir("coin");

                    Destroy(gameObject, 4f);

                    elPerso.celebracion();
                    elPerso.bloqueado = true;
                }
            }
        }
    }
}
