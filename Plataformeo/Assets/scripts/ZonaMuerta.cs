using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    public GameObject splashHeartPrefab;
    //private EfectosSonoros misSonidos;

    void start()
    {
        //misSonidos = GetComponent<EfectosSonoros>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            elPerso.muerteInsta(this.gameObject);


            GameObject efectoSplash = Instantiate(splashAguaPrefab);
            efectoSplash.transform.position = elPerso.transform.position;
            


            //corazon roto
            GameObject efectoBroke = Instantiate(splashHeartPrefab);

            efectoBroke.transform.position = elPerso.transform.position;
        }
    }
} 
//private EfectosSonoros misSonidos;
//misSonidos = GetComponent<EfectosSonoros>();
//misSonidos.reproducir("muerte");
//misSonidos.reproducir("daño");
