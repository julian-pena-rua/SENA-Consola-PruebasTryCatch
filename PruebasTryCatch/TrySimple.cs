using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasTryCatch
{
    class TrySimple
    {
        static void Main(string[] args) {
            int n, n1;
            try
            {
                /*  operacion aritmética: divisón por cero   */
                n = 123;
                n1 = 0;
                Console.Write(n/n1);
                Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No se puede dividir por cero, intentarlo de nuevo");       
            }
        }
    }
}
