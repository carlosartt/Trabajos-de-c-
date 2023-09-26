using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Email
    {
        public string subject;
        public string contenido;
        public string destinatario;

        public Email (string suj, string cont, string dest)
        {
            subject = suj;
            contenido = cont;
            destinatario = dest;
        }

        public void leer()
        {
            Console.WriteLine("DE "
                + subject + " Para mi "+ destinatario + contenido );
        }
    }
}
