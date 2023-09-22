using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresArreglo
{
    class GeneradorDeNombres
    {
        public string[] nombre = {
            "Su", "yu", "sol", "ju",
            "hwa", "eun", "ye", "do",
            "seung", "jang", "hyo", "ji",
            "se", "in","je", "tae", "jin",
            "so", "seol", "jun", "da","song",
            "jeong", "yeon", "cha", "seong",
            "min", "sin", "chae", "gang"
                };
        public string[] apellidoPaterno = {
            "Seo", "Jo", "Choe", "Lee",
            "Bae", "Yun", "Jeong", "Han",
            "Im", "Bak", "Jang", "Kim"
                };
        public string[] apellidoMaterno = {
            "ni", "a", "hui", "min", "an",
            "li", "yeong", "i", "na", "yun ",
            "hun", "hyeon", "u", "min", "bin",
            "seog", "ho", "seog", "gyu"
                };

        public void generar()
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(i + " .-" + nombre[i]);
            }

            Console.Read();
        }

    }
}
