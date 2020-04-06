using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1");
            int[] array = new int[5];
            int maximo=array[0];
            int minimo=array[0];
            int promedio=0,acum=0;
            bool flag = false;
            //f10->debuguea paso a paso pero NO entra en los metodos / funciones
            //f11->SI debugea dentro de un metodo
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingrese un numero");
                array[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {

                if (flag == false || array[i] > maximo  )
                {
                    maximo = array[i];
                }
                if (flag == false || array[i] < minimo)
                {
                    minimo = array[i];
                    flag = true;
                }
                acum = acum + array[i];
                
            }
            promedio = acum / 5;
            Console.WriteLine("El numero maximo es: {0}. El numero minimo es: {1}.\nEl promedio es: {2}",maximo,minimo,promedio);
            //foreach (int aux in array)
            //{
            //    Console.WriteLine("Mostrar numero: {0}", aux);


            //}

            Console.ReadKey();
        }
    }
}
