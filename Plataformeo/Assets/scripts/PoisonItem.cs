using System.Collections;
using UnityEngine;

public class PoisonItem : MonoBehaviour
{
    //public EfectoSonoros misSonidos;
    public int puntosDanio = 1;
    public float duracionVeneno = 5f; // Duraci�n del veneno en segundos
    public GameObject efectoVenenoPrefab;

    private void Start()
    {
        //misSonidos = GetComponent<EfectoSonoros>();
    }

    IEnumerator DanoVeneno(Personaje jugador)
    {
        float tiempoPasado = 0f;

        while (tiempoPasado < duracionVeneno)
        {
            jugador.hacerDanio(puntosDanio, this.gameObject);
            yield return new WaitForSeconds(1f); // Da�o cada segundo
            tiempoPasado += 1f;
        }

        Destroy(gameObject); // Destruir el objeto de veneno despu�s de la duraci�n
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.tag == "Player")
        {
            print(otro.name + " toc� " + name);

            Personaje elPerso = otro.GetComponent<Personaje>();
            //misSonidos.reproducir("veneno");

            GameObject efectoDanio = Instantiate(efectoVenenoPrefab);

            efectoDanio.transform.position = transform.position;

            StartCoroutine(DanoVeneno(elPerso));
        }
    }
}
