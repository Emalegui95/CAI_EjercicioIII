using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioIII
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            int incr = 0;
            int decre = palabra.Length - 1;
            bool esError = false;

            while ((incr < decre) && (!esError))
            {
                if (palabra[incr] == palabra[decre])
                {
                    incr++;
                    decre--;
                }
                else
                {
                    esError = true;
                }

            }

            if (!esError)
            {
                Console.WriteLine("La palabra " + palabra + " es un palindromo");
            }
            else
            {
                Console.WriteLine("La palabra " + palabra + " no es un palindromo");
            }

            Console.ReadLine();
        }
    }
}
