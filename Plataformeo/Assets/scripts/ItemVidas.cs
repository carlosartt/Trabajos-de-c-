using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemVidas : MonoBehaviour
{
    private Animator miAnimador;
    private EfectoSonoros misSonidos;
    private bool cofreObtenido = false;
    private GameObject hueso;
    private int cantHuesos = 1;

    // Start is called before the first frame update
    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
        miAnimador = GetComponent<Animator>();
        hueso = GameObject.Find("Huesos");
        hueso.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player") && !cofreObtenido)
        {

            Personaje elPerso = col.GetComponent<Personaje>();
            if (elPerso != null)
            {
                elPerso.ganarHuesos(cantHuesos, this.gameObject);
                cofreObtenido = true; // Marcar el cofre como obtenido
            }
           
            print(col.name + " tocó " + name);
            hueso.SetActive(true);
            misSonidos.reproducir("obtener");
            miAnimador.SetTrigger("Desaparecer");
            Destroy(gameObject, 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        hueso.SetActive(false);
    }
}

