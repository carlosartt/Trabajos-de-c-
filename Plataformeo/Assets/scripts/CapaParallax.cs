using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapaParallax : MonoBehaviour
{
    public float porcentajeAlcance = 1;
    public float anchoFondo = 20;
    public float anchoCamara = 18;

    public float posXInicial;
    public float ditanciaActualCamara;
    public float diferenciaX;

    private Transform laCamara;


    // Start is called before the first frame update
    void Start()
    {
        laCamara = GameObject.FindFirstObjectByType<Camera>().transform;

        posXInicial = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float xCamaraActual = laCamara.position.x;
        float xCapaActual = transform.position.x;

        diferenciaX =
            xCamaraActual - posXInicial;

        float distanciaReal = xCamaraActual - xCapaActual;
        float distMax = anchoCamara / 2 + anchoFondo / 2;

        Vector3 posNueva;

        if (distanciaReal > distMax)
        {//se sale de la camara

            float xNueva = xCamaraActual + distMax;
            posNueva = new Vector3(
            xNueva,
            transform.position.y,
            transform.position.z);

            posXInicial = xNueva;

        }
        else
        { //aun no sale de la camara
            diferenciaX = xCamaraActual - posXInicial;
            posNueva = new Vector3(
            xCamaraActual - diferenciaX * porcentajeAlcance,
            transform.position.y,
            transform.position.z);

          
        }

        transform.position = posNueva;
    }
}
