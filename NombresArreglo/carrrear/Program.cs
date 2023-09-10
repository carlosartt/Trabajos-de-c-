using System;


namespace coches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.modelo = "Ferrari F1";
            ferrari.velocidad = 120;

            Auto mclaren = new Auto();
            mclaren.modelo = "MC 2443";
            mclaren.velocidad = 140;

            PistaCarreras pista1 = new PistaCarreras();
            pista1.Nombre = "Hermanos Rodriguez";
            pista1.longitud = 4.30f; //km

            pista1.Competir(ferrari, mclaren);

            Console.ReadLine();
        }
    }
}
