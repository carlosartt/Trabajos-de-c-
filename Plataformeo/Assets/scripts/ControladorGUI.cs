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
    public Text EtiquetaDinero;
    public Text EtiquetaHuesos;
    
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
        EtiquetaVidasHeroe.text = Personaje.vidas + " UP";
        EtiquetaScoreHeroe.text = "HIGH SCORE: " + Heroe.score;
        EtiquetaDinero.text = "$" + Heroe.dinero;
        EtiquetaHuesos.text = "X" + Heroe.huesos;
     
       

        /* Calculo el porcenatje de hp
          que le queda al cavernicola*/

        float porcentanjeHPHeroe = Heroe.hp / (float)Heroe.hpMax;

        BarraHPHeroe.fillAmount = porcentanjeHPHeroe;


        
    }
}
