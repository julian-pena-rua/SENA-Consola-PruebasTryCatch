using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasTryCatch
{
    class TryAvanzado
    {
        static void Main(string[] args)
        {
            int n, n1;
            try
            {
                /*  operacion aritmética: divisón por cero   */

                n = 123;
                n1 = int.Parse(Console.ReadLine());
                Console.Write(n / n1);

                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ambos números deben ser mayores que cero");
            }
            catch (Exception e)
            {
                throw e; // conocer el nombre de la excepción

            }
            Console.ReadKey();
        }

    }
}
