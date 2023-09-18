using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            
            cuenta.setpin(202222964);
            cuenta.getpin();

            cuenta.setsaldo(15000);
            cuenta.getsaldo();            

            Console.ReadLine();


        }
    }
}
