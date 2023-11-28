using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSuave : MonoBehaviour

{
    public Personaje objetivo;

    public float offsetProfundidad = 5;
    public float offsetVertical = -1;
    public float velocidadAlcance = 2;


    //LateUptade is called once per frame after all Uptades
    void LateUpdate()
    {
        Vector3 posDestino = new Vector3(
            objetivo.transform.position.x,
            objetivo.transform.position.y + offsetVertical,
            objetivo.transform.position.z + offsetProfundidad);

        transform.position = Vector3.Lerp(
            transform.position,
            posDestino,
            Time.deltaTime * velocidadAlcance);
    }
}
