using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequeno : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    
   

    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
            {
           
            print(name + "enemigo cerca de " + otroObjeto);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            float posicionHeroe = otroObjeto.transform.position.x;
            float posicionEnemigo = this.transform.position.x;
            
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
         GameObject otroObjeto = col.gameObject;
         if (otroObjeto.tag == "Player")
         {
            print(name + "enemigo lejos de " + otroObjeto);
         }
    }
    
}
