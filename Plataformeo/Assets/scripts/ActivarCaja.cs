using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCaja : MonoBehaviour
{

    private GameObject boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {

            print(otro.name + " toco " + name);
            Personaje elPerso = otro.GetComponent<Personaje>();
            





        }



    }
    public void activarCofre()
    {
       
    }
}
