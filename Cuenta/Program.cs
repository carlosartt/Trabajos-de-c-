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
            cuenta.getpin();
            cuenta.setpin(1234);

            cuenta.getsaldo();
            cuenta.setsaldo(33);
            Console.ReadLine();


        }
    }
}
