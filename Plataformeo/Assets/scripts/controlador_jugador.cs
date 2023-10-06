using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_jugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    public float fuerzaSalto = 20;
    public bool enPiso = false;
    public int contSaltos = 2;

    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //lo primero en el uptade es detectar el piso
        detectarPiso();

        float velVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)//Se mueve a la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

            MiCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);

            MiAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0) //Se mueve a la izq
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            MiCuerpo.velocity = new Vector3(-velocidadCaminar, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            MiCuerpo.velocity = new Vector3(0, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (contSaltos > 0)
            if (enPiso)
            {
                    
                MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                contSaltos--;
                }
            else
            {
                MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                contSaltos --; //Disminuye los saltos
            }
        }

        MiAnimador.SetFloat("VEL_VERT", velVert);
    }

    void detectarPiso()
    {
        enPiso = Physics2D.Raycast(
            transform.position, //Desde donde sale el rayo
            Vector2.down, //En que direccion
            0.1f //Que tan largo
            );

        if (enPiso)
        {
            contSaltos = 1;
        }
    }
}
