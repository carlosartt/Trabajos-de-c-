using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    public GameObject splashHeartPrefab;
    private EfectoSonoros misSonidos;

    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.CompareTag("Player"))
        {
            print(name + " detecté colisión con " + otroObjeto.name);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            elPerso.muerteInsta(this.gameObject);

            GameObject efectoSplash = Instantiate(splashAguaPrefab);
            efectoSplash.transform.position = elPerso.transform.position;

            if (misSonidos != null)
            {
                misSonidos.reproducir("splash"); // Reproduce el sonido "splash" del componente EfectoSonoros.
            }

            // Corazón roto
            GameObject efectoBroke = Instantiate(splashHeartPrefab);
            efectoBroke.transform.position = elPerso.transform.position;
        }
    }
}