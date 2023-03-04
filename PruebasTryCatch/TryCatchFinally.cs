using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebasTryCatch
{
    class TryCatchFinally
    {
        static void Main(string[] args)
        {
            int n, n1;
            bool continuar;
            do
            {
                int numerador = 10;
                Console.WriteLine("Numerador es = {0}", numerador);
                Console.Write("Denominador = ");
                string strDen = Console.ReadLine();

                int denominador, cociente;

                try
                {
                    continuar = false;
                    Console.WriteLine("--> try");
                    denominador = Convert.ToInt16(strDen);
                    cociente = numerador / denominador;
                    Console.WriteLine("Cociente = {0}", cociente);
                }

                catch (ArithmeticException e)
                {
                    Console.WriteLine("--> catch");
                    Console.WriteLine("Excep. aritmética");
                    Console.WriteLine("ArithmeticException Handler: {0}",
                       e.ToString());
                    continuar = true;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("--> catch");
                    Console.WriteLine("Excep. de argumento nulo");
                    Console.WriteLine("ArgumentNullException Handler: {0}",
                       e.ToString());
                    continuar = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("--> catch");
                    Console.WriteLine("generic Handler: {0}",
                       e.ToString());
                    continuar = true;
                }
                finally
                {
                    Console.WriteLine("--> finally");
                }

                Console.ReadLine();

            } while (continuar);
            Console.ReadKey();

        }
    }
}
