using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[RequireComponent(typeof(AudioSource))]

public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource reproductor;

    public void reproducir(string accion)
    {
        foreach(Efecto e in misEfectos)
        {
            //Si lo accion del efecto corresponde 
            //a la accion solicitada en el param
            if (e.accion == accion)
            {
                //asigno el sonido al reproductor
                reproductor.clip = e.sonido;
                reproductor.Play();
                //corto la ejecucion del metodo
                return;
            }
        }
    }

    [Serializable]

    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }
}
