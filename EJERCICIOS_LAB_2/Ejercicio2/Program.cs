using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Mi ejemplo jueguito";

            //Level.MostrarLevelActual();

            //Player j1 = new Player();

            //Player j2 = new Player();
            ////j1.name = "Pepe";
            //j1.isHero = false;
            //j1.lifeLevel = 100;
            //j1.armorLevel = 200;

            //j1.CambiarNombre("Pepe");

            ////j2.name = "Juancita";
            //j2.isHero = true;
            //j2.lifeLevel = 200;
            //j2.armorLevel = 250;

            //j1.MostrarDatos(); //metodo de instancia
            //j2.MostrarDatos(); //metodo de instancia
            double numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = Double.Parse(Console.ReadLine());
            if (numero>=0)
            {
                while (numero <= 0)
                {
                    Console.WriteLine("RE-Ingrese el numero: ");
                    numero = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("El cuadrado del numero es: {0} y el cubo del numero es: {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            }


            Console.ReadKey();
        }
    }
}
