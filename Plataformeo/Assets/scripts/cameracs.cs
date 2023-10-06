using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracs : MonoBehaviour
{
    //Esto es un atributo publico
    public Transform Cavernicola;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        Cavernicola.position.x, //la pos x de la cam
        Cavernicola.position.y, //la pos y
    -1); //la pos de z
    }
}