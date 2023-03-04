using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasTryCatch
{
    class TryCatchAvanzadoBucle
    { 
        static void Main(string[] args)
        {
            int n, n1;
            bool continuar;
            do 
            {
                try
                {
                    /*  operacion aritmética: divisón por cero   */
                    continuar = false;
                    n = 123;
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write(n / n1);
                    continuar = true;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Ambos números deben ser mayores que cero");
                    continuar = true;
                   
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Sólo se admiten números");
                    continuar = true;

                }
                catch (Exception e)
                {
                    throw e; // conocer el nombre de la excepción
                    continuar = true;
                }
            } while(continuar);
            Console.ReadKey();
        }
    }
}
