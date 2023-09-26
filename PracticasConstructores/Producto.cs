using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Producto
    {
        public string nombre;
        public float precio;

        public Producto(string valorNombre, float valorprecio)
        {  
            nombre = valorNombre;
            precio = valorprecio;
        }
        public void describir()
        {
            Console.WriteLine("Producto "
                + nombre + " Valor=" + precio);
        }

        public float calcIva()
        {
            float precioIVA = precio * 1.16f;
            return precioIVA;
        }
    }
}
