using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_listo
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorNombres nomCore = new GeneradorNombres();

            nomCore.generar(3, 2, 2);
            Console.ReadLine();
        }
    }
}
