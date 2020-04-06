using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroPrimo=2;
            int contador = 0;
            int aux=2;
            bool primo = false;
            Console.WriteLine("Ingrese un numero");
            numeroIngresado = int.Parse(Console.ReadLine());
            
                for (int i = 2; i <= numeroIngresado; i++)
                {
                    
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                contador++;
                            }

                        }
                        if (contador <= 2)
                        {
                            Console.WriteLine("{0}", i);
                        }
                        else
                        {
                            Console.WriteLine("No es primo" + i);
                        }
                        contador = 0;
                    
                }
            Console.ReadKey();
        }
    }
}
