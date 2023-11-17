/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Vector3 respawnPoint;

    void Start()
    {
        // Establece la posici�n inicial como la posici�n de respawn
        respawnPoint = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    public void SetRespawnPoint(Vector3 newRespawnPoint)
    {
        // Actualiza la posici�n de respawn
        respawnPoint = newRespawnPoint;
    }

    public void RespawnPlayer()
    {
        // Respawn del jugador en la posici�n de respawn
        GameObject.FindGameObjectWithTag("Player").transform.position = respawnPoint;

        // Puedes agregar efectos visuales o sonoros aqu� si lo deseas
    }

    public void GameOver()
    {
        // Manejar la l�gica del Game Over, como cargar una escena de Game Over
        SceneManager.LoadScene("GameOver");
    }
}




using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Obt�n el GameManager y actualiza la posici�n de respawn
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.SetRespawnPoint(transform.position);
            }

            // Puedes agregar efectos visuales o sonoros aqu� si lo deseas
        }
    }
}


using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 70;
    public int hpMax = 100;
    public static int vidas = 3;
    public int vidasMin = 1;
    public bool bloqueado = false;

    private Animator miAnimado;
    private EfectoSonoros misSonidos;

    void Start()
    {
        miAnimado = GetComponent<Animator>();
        misSonidos = GetComponent<EfectoSonoros>();
    }

    void Update()
    {
        if (hp <= 0 && vidas > 0)
        {
            vidas--;
            bloqueado = true;

            // Respawn del jugador a trav�s del GameManager
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.RespawnPlayer();
            }

            Invoke("desbloquear", 1.2f);
        }

        if (hp <= 0 && vidas <= 0)
        {
            // Game Over a trav�s del GameManager
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }
    }

    void desbloquear()
    {
        bloqueado = false;
    }
}
*/