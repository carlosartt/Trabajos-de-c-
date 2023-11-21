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


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracs : MonoBehaviour
{
    public Personaje Cavernicola;
    public float velocidadAcerca = 0.1f;
    public float distanciaMinima = 2.0f;
    public float zoomFactor = 2.0f; // Aumento al doble
    public string metaTag = "MetaTag"; // Etiqueta del GameObject "meta"

    private bool haciendoZoom = false;

    // Start is called before the first frame update
    void Start()
    {
        // Puedes colocar aquí cualquier inicialización adicional que necesites
    }

    // Update is called once per frame
    void Update()
    {
        if (Cavernicola.estaVivo())
        {
            if (!haciendoZoom)
            {
                transform.position = new Vector3(
                    Cavernicola.transform.position.x,
                    Cavernicola.transform.position.y,
                    -1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto con el que colisionó tiene la etiqueta adecuada
        if (other.CompareTag(metaTag))
        {
            StartCoroutine(HacerZoom());
        }
    }

    private IEnumerator HacerZoom()
    {
        haciendoZoom = true;

        // Almacena la posición original de la cámara antes del zoom
        Vector3 posicionOriginal = transform.position;

        // Calcula la posición de destino para el zoom
        Vector3 posicionDestino = new Vector3(
            Cavernicola.transform.position.x,
            Cavernicola.transform.position.y,
            -1) - transform.forward * distanciaMinima * zoomFactor;

        // Realiza el zoom suavemente
        float tiempoPasado = 0f;
        while (tiempoPasado < 1f)
        {
            transform.position = Vector3.Lerp(posicionOriginal, posicionDestino, tiempoPasado);
            tiempoPasado += Time.deltaTime * velocidadAcerca;
            yield return null;
        }

        haciendoZoom = false;
    }
}*/
