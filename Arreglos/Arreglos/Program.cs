using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            

            GeneradorNombres nomcore = new GeneradorNombres();
            
            nomcore.generar(3, 2, 2);
            Console.ReadLine();
            
        }
    }
}
