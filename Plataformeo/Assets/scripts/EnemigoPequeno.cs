using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequeno : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public bool heroeCerca = false;
    public float velocidadCaminar = 3;



    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    void Uptade()
    {
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
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {

            print(name + "enemigo cerca de " + otro.name);
            heroeCerca = true;

            if (otro.transform.position.x < this.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            Personaje elPerso = otro.GetComponent<Personaje>();
            float posicionHeroe = otro.transform.position.x;
            float posicionEnemigo = this.transform.position.x;


        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Player")
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