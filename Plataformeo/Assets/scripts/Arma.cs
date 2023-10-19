using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.tag == "Enemigo")
        {
            print(name + " detecte colision con " + otro);

            Personaje elPerso = otro.GetComponent<Personaje>();

            elPerso.hacerDanio(5, this.gameObject);

        }

    }
}






