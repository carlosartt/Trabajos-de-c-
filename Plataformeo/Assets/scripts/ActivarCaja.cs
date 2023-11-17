using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCaja : MonoBehaviour
{
    private Animator miAnimador;
    private EfectoSonoros misSonidos;
    public GameObject cofreItem;
    public float cofreDelay;
    public bool cofreObtenido = false;
    public GameObject botonE;

    // Start is called before the first frame update
    void Start()
    {

        misSonidos = GetComponent<EfectoSonoros>();
        miAnimador = GetComponent<Animator>();
        botonE = GameObject.Find("BotonE");
        botonE.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (!cofreObtenido)
            {
                print(col.name + " toco " + name);
                botonE.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E) && !cofreObtenido)
                {
                    misSonidos.reproducir("abrir");
                    miAnimador.Play("cofre_abrir");
                    Invoke("ObtenerCofreItem", cofreDelay);
                    Destroy(gameObject, 1f);
                    botonE.SetActive(false);
                }
            }
            else
            {
                // Si el ítem ya ha sido tomado, desactivar el botónE
                botonE.SetActive(false);
            }

        }

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        botonE.SetActive(false);
    }

    void ObtenerCofreItem()
    {
        if (!cofreObtenido)
        {
            Instantiate(cofreItem, transform.position, Quaternion.identity);
            cofreObtenido = true;
        }

    }
}
