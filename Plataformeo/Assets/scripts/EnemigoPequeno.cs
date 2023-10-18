using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequeno : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    public bool heroeCerca = false;
    public float velocidadCaminar= 3;
    
   

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
            heroeCerca = true;

            if (otroObjeto.transform.position.x < this.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            float posicionHeroe = otroObjeto.transform.position.x;
            float posicionEnemigo = this.transform.position.x;
            
           
        }
                
                
                
                

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         GameObject otroObjeto = collision.gameObject;
         if (collision.tag == "Player")
         {
            print(collision.gameObject.name + " lejos de " + name);
            heroeCerca = false;
         }
         
    }

    void Uptade()
    {
        if (heroeCerca)
        {
            MiCuerpo.velocity = transform.right * velocidadCaminar;
            MiAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            MiCuerpo.velocity = Vector3.zero;
            MiAnimador.SetBool("CAMINANDO", false);
        }
    }
    
}
