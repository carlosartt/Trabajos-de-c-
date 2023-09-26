using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Zapato
    {
        public string color;
        public float talla;

        public Zapato(string col, float num)
        {
            color = col;
            talla = num;
        }
        public void describir()
        {
            Console.WriteLine("El zapato es de color "
                + color + " y su talla es " + talla);
        }
    }
}
