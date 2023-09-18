using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    public class CuentaBancaria
    { 
    private int pin;
    private int saldo;


    public void setpin(int digito)
    {
            Console.WriteLine("Bienvenido a tu cuenta bancaria");

            pin = digito;
            
        }

        public int getpin()
    {
            Console.WriteLine("Tu pin es " + pin);
        return pin;
    }
    
     public void setsaldo(int valor)
    {
        saldo = valor;
    }

    public int getsaldo()
    {
            

            if (pin > 0)//Si hay un digito
            {
                Console.WriteLine("Tu saldo es:$" + saldo + ""); 
                
            }
            else
            {
                Console.WriteLine("No hay pin. No Puedes acceder a tu saldo.");
            }

            return pin;
    }

}
}
