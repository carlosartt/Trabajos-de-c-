using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();//invocacion del componente 
        miAnimador = GetComponent<Animator>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 miPos = this.transform.position;
        Vector3 posHeroe = heroeJugador.transform.position;
        float distanciaheroe = (miPos - posHeroe).magnitude;

        
            if (distanciaheroe < rangoAgro)
            {//el heroe esta dentro del area de agro
                print(heroeJugador.name + " cerca de " + name);
                heroeCerca = true;

                if (heroeJugador.transform.position.x < this.transform.position.x)
                {
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        
        else
        {
            heroeCerca = false;
        }


        if (heroeCerca)
        {
            miCuerpo.velocity = transform.right * velocidadCaminar;
            miAnimador.SetBool("CAMINANDO", true);


        }

        else
        {
            miCuerpo.velocity = Vector3.zero;
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

            if (otro.transform.position.x < this.transform.position.x)
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
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            print(name + " detecte colision con " + otro);

            Personaje elPerso = otro.GetComponent<Personaje>();

            elPerso.hacerDanio(5, this.gameObject);
        }
    }
}

