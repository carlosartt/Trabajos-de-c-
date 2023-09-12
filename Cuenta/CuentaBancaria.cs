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

    public int getpin()
    {
       
        return pin;
    }
    public void setpin(int digito)
    {
        pin = digito;
    }


    public int getsaldo()
    {
            if (pin > 0)//Si hay un digito
            {
            }
            else
            {
                Console.WriteLine("No hay pin");
            }

            return pin;
    }

    public void setsaldo(int valor)
    {
        saldo = valor;
    }

}
}
