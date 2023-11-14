

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostItem : MonoBehaviour
{
    private Animator miAnimador;
    private controlador_jugador elPerso;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {
            
            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();

            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);

                elPerso = otro.GetComponent<controlador_jugador>();

                if (elPerso != null)
                {
                    elPerso.velocidadCaminar *= 2;
                    miAnimador.SetTrigger("destroy");
                    Invoke("restaurarVelocidad", 3);
                    Invoke("destruirObjeto", 3);
                }
            }
        }
    }


    public void restaurarVelocidad()
    {
        Debug.Log("Restaurando velocidad");
        if (elPerso != null)
        {
            elPerso.velocidadCaminar /= 2;
            Debug.Log("Nueva velocidad: " + elPerso.velocidadCaminar);
        }
    }


    public void destruirObjeto()
    {
        Destroy(gameObject);
        Debug.Log("objeto destruido");
    }
}