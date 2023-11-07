using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoro : MonoBehaviour
{
    public int cantDinero = 1;
    private EfectoSonoros misSonidos;
    private Animator MiAnimador;

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
            
            print(otro.name + " toco " + name);
            Personaje elPerso = otro.GetComponent<Personaje>();
            misSonidos.reproducir("coin");

            elPerso.ganarDinero(cantDinero, this.gameObject);
            MiAnimador.SetTrigger("Desaparecer");

            Destroy(gameObject, 0.5f);
            
        }



    }

    
    
    
}
