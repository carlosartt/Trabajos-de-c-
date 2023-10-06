using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGUI1 : MonoBehaviour
{
    public Personaje Enemigo;
    public Text EtiquetaHPEnemigo;
    public Text EtiquetaVidasEnemigo;
    public Text EtiquetaScoreEnemigo;
    
    public Image BarraHPEnemigo;
    public Image BarraScoreEnemigo;
    public Image BarraEstatusEnemigo;

   
    //public Image BarraVidasHeroe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Muestro en texto el HP
        EtiquetaHPEnemigo.text = Enemigo.hpMax + "/" +  Enemigo.hp;
        EtiquetaVidasEnemigo.text = Enemigo.vidas + " UP";
        EtiquetaScoreEnemigo.text = "HIGH SCORE: " + Enemigo.score;

        /* Calculo el porcenatje de hp
          que le queda al cavernicola*/

        float porcentanjeHPEnemigo = Enemigo.hp / (float)Enemigo.hpMax;

        BarraHPEnemigo.fillAmount = porcentanjeHPEnemigo;


        /*float porcentanjeScoreHeroe = Heroe.score / (float)1000;

        BarraHPHeroe.fillAmount = porcentanjeScoreHeroe;*/
    }
}
