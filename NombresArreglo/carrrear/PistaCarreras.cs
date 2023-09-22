using System;

namespace coches
{
    public class PistaCarreras
    {
        public string Nombre;
        public float longitud;

        public void Competir(Auto auto1, Auto auto2)

        {//este es el bloque de metodo
            Console.WriteLine(
                //se perdio el nombre de ferrari
                "iniciando competencia entre"
                + auto1.modelo + "contra"
                + auto2.modelo);

            if (auto1.velocidad > auto2.velocidad)
            {
                Console.WriteLine("gano" + auto1.modelo);
            }
            else if (auto2.velocidad > auto1.velocidad)
            {
                Console.WriteLine("gano" + auto2.modelo);
            }
            else
            {
                Console.WriteLine("Hubo un empate");
            }
        }
    }
}

