/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaScript : MonoBehaviour
{
    private EfectoSonoros misSonidos;
    private Animator MiAnimador;
    public GameObject efectoChispasPrefab;
 

    private bool chispasEnProceso = false;
    private bool bucleChispas = false;

    // Start is called before the first frame update
    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
        MiAnimador = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (collision.gameObject.tag == "Player")
        {

      
    


            Invoke("PasarNivel", 5f);
            
            misSonidos.reproducir("celebracion");

            

            // Inicia el bucle de chispas cuando el jugador entra en colisión con la meta
            bucleChispas = true;

            // Si las chispas no están en proceso, inicia el proceso
            if (!chispasEnProceso)
            {
                StartCoroutine(ProcesoChispas());
            }
        }
    }

    private void PasarNivel()
    {
        SceneManager.LoadScene(2);
    }

    private IEnumerator ProcesoChispas()
    {
        while (bucleChispas) // Bucle infinito mientras la bandera esté activa
        {
            chispasEnProceso = true;
            CrearEfectoChispas(transform.position);
            yield return new WaitForSeconds(1f); // Ajusta este tiempo según tu preferencia
        }

        chispasEnProceso = false;
    }

    private void CrearEfectoChispas(Vector3 position)
    {
        GameObject efectoChispas = Instantiate(efectoChispasPrefab);
        efectoChispas.transform.position = position;
    }
}*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaScript : MonoBehaviour
{
    public GameObject gemaPrefab;
    
    private Gema gema; // Asumiendo que Gema es el script adjunto al prefab de la gema
    private bool contacto = false;
    private bool trowGema = false;
    private EfectoSonoros misSonidos;
    public GameObject efectoChispasPrefab;


    private bool chispasEnProceso = false;
    private bool bucleChispas = false;

    void Start()
    {
        misSonidos = GetComponent<EfectoSonoros>();
        
    }

    void Update()
    {
        if (contacto && !trowGema)
        {
            Vector3 metaPosition = transform.position;
            GameObject newItem = Instantiate(gemaPrefab, metaPosition, Quaternion.identity);
            //misSonidos.reproducir("meta");

            // Obtén la referencia al componente Gema del objeto recién instanciado
            gema = newItem.GetComponent<Gema>();
          

            if (gema != null )
            {
                
                trowGema = true;
            }
        }

        if (gema != null && gema.GemaRecogida)
        {
            misSonidos.reproducir("celebracion");
            bucleChispas = true;
            // Si las chispas no están en proceso, inicia el proceso
            if (!chispasEnProceso)
            {
                StartCoroutine(ProcesoChispas());
            }

            if (gema.CompareTag("Vidas"))
            {
                // Sumar 2 vidas al jugador
                SumarVidas(2);
            }
            Invoke("PasarNivel", 10f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        if (otro.CompareTag("Player"))
        {
            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();
            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);
                contacto = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        contacto = false;
    }

    private void PasarNivel()
    {
      
        SceneManager.LoadScene(2);
    }

    private IEnumerator ProcesoChispas()
    {
        while (bucleChispas) // Bucle infinito mientras la bandera esté activa
        {
            chispasEnProceso = true;
            CrearEfectoChispas(transform.position);
            yield return new WaitForSeconds(1f); // Ajusta este tiempo según tu preferencia
        }

        chispasEnProceso = false;
    }

    private void CrearEfectoChispas(Vector3 position)
    {
        GameObject efectoChispas = Instantiate(efectoChispasPrefab);
        efectoChispas.transform.position = position;
    }

    private void SumarVidas(int cantidad)
    {
        // Asumiendo que el script del jugador se llama "Personaje"
        Personaje elPerso = FindObjectOfType<Personaje>();
        if (elPerso != null)
        {
            elPerso.ganarVidas(cantidad, this.gameObject);
        }
    }
}

