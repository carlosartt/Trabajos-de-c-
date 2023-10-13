using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Personaje : MonoBehaviour
{

    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMin = 1;
    public int score = 10;

    private Animator MiAnimado;
    //private EfectosSonoros misSonidos;

    public GameObject heridasBloodPrefab;
    public GameObject vidasMenosPrefab;

    // Start is called before the first frame update
    void Start()
    {

        MiAnimado = GetComponent<Animator>();
        //misSonidos = GetComponent<EfectosSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0 && vidas > 0)
        {
            vidas--;
            hp = hpMax;

            GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);

            efectoVidasMenos.transform.position = transform.position;
            MiAnimado.SetTrigger("Muriendo");
            //misSonidos.reproducir("muerte");
        }
    }

    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        if (vidas >= vidasMin)
        {
            if (hp <= puntosDanio)
            {
                hp = 0;
            }
            else
            {
                hp -= puntosDanio;
            }
            print(name + " recibe daño de " + puntosDanio + " por " + enemigo);

            GameObject efectoDanio = Instantiate(heridasBloodPrefab);

            efectoDanio.transform.position = transform.position;
            MiAnimado.SetTrigger("Dañando");
            //misSonidos.reproducir("daño");
        }


    }

    public void muerteInsta(GameObject quien)
    {

        print(name + " murio instantaneamente por " + quien);
        hp = 0;
       
    }

}