using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public GameObject splashBloodPrefab;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();

            elPerso.hacerDanio(5, this.gameObject);

            //efecto sangre
            GameObject efectoSplash = Instantiate(splashBloodPrefab);

            efectoSplash.transform.position = elPerso.transform.position;

            
        }
        
    }

}
