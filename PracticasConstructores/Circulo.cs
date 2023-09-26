using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Circulo
    {
        public float radio;
        public float pi = 3.1416f;

        public Circulo(float valorRadio)
        { 
            radio = valorRadio;
            
        }

        public void describir()
        {
            Console.WriteLine("Circulo " +
                "2" + " x radio=" + radio + " x " + "pi");
        }

        public float calcPer()
        {
            float perimetro = 2 * pi * radio;
            return perimetro;
        }
    }
}
