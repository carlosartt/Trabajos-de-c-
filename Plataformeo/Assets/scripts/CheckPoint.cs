using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            // Guarda la posición del checkpoint como la nueva posición de respawn del jugador
            otro.GetComponent<Personaje>().SetRespawnPoint(transform.position);

           
        }
    }
}


