using System.Collections;
using UnityEngine;

public class EnemigoPequeno : MonoBehaviour
{
    public float velocidadCaminar = 3;
    private bool heroeCerca = false;
    public int puntosDanio = 10;
    public float rangoAgro = 3;

    private Animator miAnimador;
    private Rigidbody2D miCuerpo;
    private GameObject heroeJugador;

    private bool puedeMoverse = true;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Verificar si el personaje está vivo antes de realizar acciones
        if (heroeJugador.GetComponent<Personaje>().estaVivo() && puedeMoverse)
        {
            Vector3 miPos = transform.position;
            Vector3 posHeroe = heroeJugador.transform.position;
            float distanciaheroe = (miPos - posHeroe).magnitude;

            if (distanciaheroe < rangoAgro)
            {
                print(heroeJugador.name + " cerca de " + name);
                heroeCerca = true;

                if (puedeMoverse)
                {
                    if (heroeJugador.transform.position.x < transform.position.x)
                    {
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                }
            }
            else
            {
                heroeCerca = false;
                miCuerpo.velocity = Vector2.zero;
                miAnimador.SetBool("CAMINANDO", false);
            }

            if (puedeMoverse && heroeCerca)
            {
                miCuerpo.velocity = transform.right * velocidadCaminar;
                miAnimador.SetBool("CAMINANDO", true);
            }
            else
            {
                miCuerpo.velocity = Vector2.zero;
                miAnimador.SetBool("CAMINANDO", false);
            }
        }
        else
        {
            // Si el jugador está muerto, regresar al estado de idle
            heroeCerca = false;
            miCuerpo.velocity = Vector2.zero;
            miAnimador.SetBool("CAMINANDO", false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            print(otro.name + " cerca de " + name);
            heroeCerca = true;

            if (otro.transform.position.x < transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print(collision.gameObject.name + " lejos de " + name);
            heroeCerca = false;
            miCuerpo.velocity = Vector2.zero; // Detener el movimiento cuando el jugador está fuera del rango
            miAnimador.SetBool("CAMINANDO", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            print(name + " detecte colision con " + otro);

            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.hacerDanio(puntosDanio, this.gameObject);
        }
    }
}
