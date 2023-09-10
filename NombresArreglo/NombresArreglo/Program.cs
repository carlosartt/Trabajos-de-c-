using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresArreglo
{
    class GeneradorDeClases
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
            string[] apellidoPaterno = { "-",
            "Seo", "Jo", "Choe", "Lee",
            "Bae", "Yun", "Jeong", "Han",
            "Im", "Bak", "Jang", "Kim"
                };
            string[] apellidoMaterno = {
            "ni", "a", "hui", "min", "an",
            "li", "yeong", "i", "na", "yun "};

            Console.WriteLine
                ("Tu nombre segun tu dia de nacimiento ");

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(i + " .-" + nombre[i]);
            }


            Console.WriteLine
                    ("Tu apellido paterno segun tu mes de nacimiento ");

            for (int i = 0; i < apellidoPaterno.Length; i++)
            {
                Console.WriteLine(i + " .-" + apellidoPaterno[i]);
            }


            Console.WriteLine
                        ("Tu apellido materno segun el ultimo " +
                    "digito de tu año de nacimiento ");

            for (int i = 0; i < apellidoMaterno.Length; i++)
            {
                Console.WriteLine(i + " .-" + apellidoMaterno[i]);
            }

            string n1 = nombre[1];
            Console.WriteLine(n1);
            Console.Read();

        }


        public void generar(int nom ,int apePa, int apeMa )
        { 
         
        }
        
    }
}







