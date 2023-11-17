using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private EfectoSonoros misSonidos;
    private Animator MiAnimador;
    public GameObject efectoChispasPrefab;

    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
        MiAnimador = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            // Guarda la posición del checkpoint como la nueva posición de respawn del jugador
            otro.GetComponent<Personaje>().SetRespawnPoint(transform.position);
            misSonidos.reproducir("celebracion");
            MiAnimador.SetTrigger("movrap");

            GameObject efectoChispas = Instantiate(efectoChispasPrefab);
            efectoChispas.transform.position = transform.position;


        }
    }
}


