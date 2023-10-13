using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGUI2 : MonoBehaviour
{
    public Personaje Enemigo2;
    public Text EtiquetaHPEnemigo2;
    public Text EtiquetaVidasEnemigo2;
    public Text EtiquetaScoreEnemigo2;

    public Image BarraHPEnemigo2;
    public Image BarraScoreEnemigo2;
    public Image BarraEstatusEnemigo2;


    //public Image BarraVidasHeroe;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Muestro en texto el HP
        EtiquetaHPEnemigo2.text = Enemigo2.hpMax + "/" + Enemigo2.hp;
        EtiquetaVidasEnemigo2.text = Enemigo2.vidas + " UP";
        EtiquetaScoreEnemigo2.text = "HIGH SCORE: " + Enemigo2.score;

        /* Calculo el porcenatje de hp
          que le queda al cavernicola*/

        float porcentanjeHPEnemigo = Enemigo2.hp / (float)Enemigo2.hpMax;

        BarraHPEnemigo2.fillAmount = porcentanjeHPEnemigo;


        /*float porcentanjeScoreHeroe = Heroe.score / (float)1000;

        BarraHPHeroe.fillAmount = porcentanjeScoreHeroe;*/
    }
}