using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Triangulo
    {
        public float lado1;
        public float lado2;
        public float lado3;

        public Triangulo(float l1, float l2, float l3)
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;

        }

        public void describir()
        {
            Console.WriteLine("Triangulo" +
                " Lado 1= " + lado1 + " Lado 2= " + lado2 + " Lado 3= "+ lado3);
        }

        public float calcPerim()
        {
            float perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }
    }
}
