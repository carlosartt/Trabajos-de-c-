using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class GeneradorNombres

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
       
       
            string[] apePat = { "-",
            "Seo", "Jo", "Choe", "Lee",
            "Bae", "Yun", "Jeong", "Han",
            "Im", "Bak", "Jang", "Kim"
                };
        string[] apeMat = {
            "ni", "a", "hui", "min", "an",
            "li", "yeong", "i", "na", "yun "};


        public void generar(int dia, int mes, int año)
        {
            Console.WriteLine("Tu nombre coreano segun tu dia, " +
                "mes y ultimo digito de tu año de nacimiento ");
            
            Console.WriteLine("");
            for (int i = 0; i < nombre.Length; i++)
            {
                
                Console.WriteLine(i+ ".-" + nombre[i]);
                
            }
            Console.WriteLine("");
            for (int i = 0; i < apePat.Length; i++)
            {
                
                Console.WriteLine(i + ".-" + apePat[i]);
                
            }
            Console.WriteLine("");
            for (int i = 0; i < apeMat.Length; i++)
            {
                Console.WriteLine(i + ".-" + apeMat[i]);
                
            }

            Console.WriteLine("");
            Console.WriteLine("Tu nombre coreano es: ");
            Console.WriteLine( apePat[mes] +" " + nombre[dia] + " " + apeMat[año]);          

        }
    }
}
