using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControladorJuego : MonoBehaviour
{
    public static ControladorJuego Instance;
    [SerializeField] private GameObject[] puntosDeControl;
    [SerializeField] private GameObject jugador;

    private int indexPuntosDeControl;

    private void Awake()
    {
        Instance = this;
        puntosDeControl = GameObject.FindGameObjectsWithTag("CheackPoint");
        indexPuntosDeControl = PlayerPrefs.GetInt("puntosIndex");
        Instantiate(jugador, puntosDeControl[indexPuntosDeControl].transform.position, Quaternion.identity);

    }
    public void ultimoPuntoDeControl(GameObject puntoControl)
    {
        for (int i=0; i < puntosDeControl.Length; i++)
        {
            PlayerPrefs.SetInt("puntosIndex", i);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

