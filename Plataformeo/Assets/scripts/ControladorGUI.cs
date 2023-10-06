using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGUI : MonoBehaviour
{
    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Text EtiquetaVidasHeroe;
    public Text EtiquetaScoreHeroe;
    
    public Image BarraHPHeroe;
    public Image BarraScoreHeroe;
    public Image BarraEstatusHeroe;

   
    //public Image BarraVidasHeroe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Muestro en texto el HP
        EtiquetaHPHeroe.text = Heroe.hp + "/" + Heroe.hpMax;
        EtiquetaVidasHeroe.text = Heroe.vidas + " UP";
        EtiquetaScoreHeroe.text = "HIGH SCORE: " + Heroe.score;

        /* Calculo el porcenatje de hp
          que le queda al cavernicola*/

        float porcentanjeHPHeroe = Heroe.hp / (float)Heroe.hpMax;

        BarraHPHeroe.fillAmount = porcentanjeHPHeroe;


        
    }
}
