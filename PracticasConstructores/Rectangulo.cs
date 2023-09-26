using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Rectangulo
    {
        //Valores de los atributos por default 
        private float ancho = 5; 
        private float alto = 10;

        //Este es un constructor
        public Rectangulo()
        {

        }

        //Este constructor pero si recibe parametros
        public Rectangulo(float valorAncho, float valorAlto)
        { // establezco el 
            ancho = valorAncho;
            alto = valorAlto;
        }

        public void describir()
        {
            Console.WriteLine("Rectangulo " 
                + ancho + "x" + alto);
        }
        public float calcArea()
        {
            float area = alto * ancho;
            return area;
        }

        public void setAlto(float valor)
        {
            alto = valor;
        }
    }
}
