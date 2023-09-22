using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = { "-",
            "Su", "yu", "sol", "ju",
            "hwa", "eun", "ye", "do",
            "seung", "jang", "hyo", "ji",
            "se", "in","je", "tae", "jin",
            "so", "seol", "jun", "da","song",
            "jeong", "yeon", "cha", "seong",
            "min", "sin", "chae", "gang"
                };

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
                Console.Read();
            }
        }
    }
}
