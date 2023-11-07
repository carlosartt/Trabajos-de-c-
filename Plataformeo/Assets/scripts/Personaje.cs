using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;
using System;


public class Personaje : MonoBehaviour
{

    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int vidasMin = 1;
    public int score = 10;
    public int dinero = 0;
    public bool bloqueado = false;
    private bool yaEjecutado = false;


    private Animator miAnimado;
    private EfectoSonoros misSonidos;

    public GameObject heridasBloodPrefab;
    public GameObject vidasMenosPrefab;
   

    // Start is called before the first frame update
    void Start()
    {

        miAnimado = GetComponent<Animator>();
        misSonidos = GetComponent<EfectoSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0 && vidas > 0)
        {
            vidas--;

            bloqueado = true;
            //Dentro de 1.2 segundos se va a ejecutar el metodo llamado desbloquear

            Invoke("desbloquear", 1.2f);

            GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);

            efectoVidasMenos.transform.position = transform.position;
            miAnimado.SetTrigger("Muriendo");
            misSonidos.reproducir("muerte");
            hp = hpMax;
            //Invoke("reiniciarNivel", 3f);

        }
        if (hp <= 0 && vidas <= 0 && !yaEjecutado)
        {
            GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);

            efectoVidasMenos.transform.position = transform.position;
            miAnimado.SetTrigger("Muriendo");
            misSonidos.reproducir("muerte");

            yaEjecutado = true;
            ;

            

            Invoke("gameOver", 2f);
        }

    }

    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        if (estaVivo())
        {
            if (vidas >= vidasMin)
            {
                hp -= puntosDanio;

                bloqueado = true;
                //Dentro de 1.2 segundos se va a ejecutar el metodo llamado desbloquear

                Invoke("desbloquear", 1.2f);

                miAnimado.SetTrigger("Dañando");
                misSonidos.reproducir("daño");

                print(name + " recibe daño de " + puntosDanio + " por " + enemigo);

                GameObject efectoDanio = Instantiate(heridasBloodPrefab);

                efectoDanio.transform.position = transform.position;

            }
        }

    }
    public void ganarDinero (int cantDinero, GameObject Tesoro)
    {
        if (estaVivo())
        {
            dinero += cantDinero;  
        }
    }



    public void muerteInsta(GameObject quien)
    {

        print(name + " murio instantaneamente por " + quien);
        hp = 0;
        vidas = 0;

        GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);

        efectoVidasMenos.transform.position = transform.position;
        miAnimado.SetTrigger("Muriendo");
        misSonidos.reproducir("muerte");
    }
    public void matar(GameObject atacante)
    {
        print(name + " muere a manos de " + atacante);
        hp = 0;
        vidas--;
    }
    public void desbloquear()
    {
        bloqueado = false;
    }

    public bool estaVivo()
    {
        return hp > 0;
    }

    public void reiniciarNivel()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void estaMuerto()
    {
        hp = 0;
        vidas = 0;

        // Llama al método para reiniciar la escena
        reiniciarNivel();
    }

}