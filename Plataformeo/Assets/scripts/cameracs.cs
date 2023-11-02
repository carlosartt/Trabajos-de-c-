using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracs : MonoBehaviour
{
    //Esto es un atributo publico
    public Personaje Cavernicola;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Cavernicola.estaVivo())
        {
            transform.position = new Vector3(
        Cavernicola.transform.position.x, //la pos x de la cam
        Cavernicola.transform.position.y, //la pos y
    -1); //la pos de z
        }

    }
}