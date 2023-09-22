using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresArreglo
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
         string[] apellidoPaterno = { "-",
            "Seo", "Jo", "Choe", "Lee",
            "Bae", "Yun", "Jeong", "Han",
            "Im", "Bak", "Jang", "Kim"
                };
         string[] apellidoMaterno = {
            "ni", "a", "hui", "min", "an",
            "li", "yeong", "i", "na", "yun "};



    public void generar(string nom, string apePa, string apeMa)
    {
        nombre = nom;
        apellidoPaterno = apePa;
        apellidoMaterno = apeMa;

    }
    }
}
