using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeNo : MonoBehaviour
{
    public int hp = 70;
    public int hpMax = 100;
    public static int vidas = 1;
    public int vidasMin = 1;
    public int score = 10;
    public bool bloqueado = false;
    private bool yaEjecutado = false;

    public GameObject cofreItem;
    public float deadDelay;
    public bool noVivo = false;

    private Animator miAnimado;
    private EfectoSonoros misSonidos;

    public GameObject heridasBloodPrefab;
    public GameObject vidasMenosPrefab;
    public GameObject efectoDesaparecerPrefab;

    // Start is called before the first frame update
    void Start()
    {

        miAnimado = GetComponent<Animator>();
        misSonidos = GetComponent<EfectoSonoros>();
    }

    // Update is called once per frame
    void Update()
    {

        if (hp <= 0 && vidas > 0 )
        {
            vidas--;

            bloqueado = true;
            //Dentro de 1.2 segundos se va a ejecutar el metodo llamado desbloquear

            Invoke("desbloquear", 1.2f);

            GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);

            efectoVidasMenos.transform.position = transform.position;
            miAnimado.SetTrigger("Muriendo");
            misSonidos.reproducir("muerte");

            hp = hpMax;
           

        }
        if (vidas <= 0 && hp <= 0 && !yaEjecutado )
        {
            if (!noVivo)
            {
                GameObject efectoVidasMenos = Instantiate(vidasMenosPrefab);

                efectoVidasMenos.transform.position = transform.position;
                miAnimado.SetTrigger("Muriendo");
                misSonidos.reproducir("muerte");

                GameObject efectoDanio = Instantiate(efectoDesaparecerPrefab);
                efectoDanio.transform.position = transform.position;

                yaEjecutado = true;

                Invoke("ObtenerItem", deadDelay);
                Destroy(gameObject, 1f);
            }


        }

    }

    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        if (estaVivo())
        {
            if (vidas >= vidasMin)
            {
                hp -= puntosDanio;

                bloqueado = true;
                //Dentro de 1.2 segundos se va a ejecutar el metodo llamado desbloquear

                Invoke("desbloquear", 1.2f);

                miAnimado.SetTrigger("Dañando");
                misSonidos.reproducir("daño");

                print(name + " recibe daño de " + puntosDanio + " por " + enemigo);

                GameObject efectoDanio = Instantiate(heridasBloodPrefab);

                efectoDanio.transform.position = transform.position;

            }
        }

    }
    public void matar(GameObject atacante)
    {
        print(name + " muere a manos de " + atacante);
        hp = 0;
        vidas--;
    }

    public void desbloquear()
    {
        bloqueado = false;
    }

    public bool estaVivo()
    {
        return hp > 0;
    }

    
    public void estaMuerto()
    {
        hp = 0;
        vidas = 0;

    }

    void ObtenerItem()
    {
        if (!noVivo)
        {
            Instantiate(cofreItem, transform.position, Quaternion.identity);
            noVivo = true;
        }

    }
}
