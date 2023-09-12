using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_listo
{
    public class GeneradorNombres
   {
        
        string[] nombres = { "-",
            "Su", "yu", "sol", "ju",
            "hwa", "eun", "ye", "do",
            "seung", "jang", "hyo", "ji",
            "se", "in","je", "tae", "jin",
            "so", "seol", "jun", "da","song",
            "jeong", "yeon", "cha", "seong",
            "min", "sin", "chae", "gang"
                };
       
       
            string[] apesPat = { "-",
            "Seo", "Jo", "Choe", "Lee",
            "Bae", "Yun", "Jeong", "Han",
            "Im", "Bak", "Jang", "Kim"
                };
        string[] apesMat = {
            "ni", "a", "hui", "min", "an",
            "li", "yeong", "i", "na", "yun "};


        public void generar(int dia, int mes, int amo)
        {
            Console.WriteLine("Tu nombre coreano segun tu dia, " +
                "mes y ultimo digito de tu año de nacimiento ");
            
            
           

            Console.WriteLine("");
            Console.WriteLine("Tu nombre coreano es: ");
            Console.WriteLine( apesPat[mes] +" " + nombres[dia] + " " + apesMat[amo]);          

        }
    }
}
   