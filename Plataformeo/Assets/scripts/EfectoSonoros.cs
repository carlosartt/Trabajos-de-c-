using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]

public class EfectoSonoros : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource reproductor;

    void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }
public void reproducir(string  accion)
    {
        foreach(Efecto e in misEfectos)
        {
        if (e.accion == accion)
            {
                reproductor.clip = e.sonido;
                reproductor.Play();

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
