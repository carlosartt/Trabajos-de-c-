using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Persona
    {
        public int nacimiento;

        public Persona (int aNac)
        {
            nacimiento = aNac;
        }
        public void describir()
        {
            Console.WriteLine("Persona nacio "
                + nacimiento);
        }

        public int calEdad()
        {
            int Edad = 2023 - nacimiento;
            return Edad;
        }
    }
}
