using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creando un objeto persona tipo referencia
            Persona persona = new Persona();
            persona.Edad = 2;
            int edad = 21;

            //Clase protected, tiene scoop solo dentro del mismo proyecto
            //privada solo para el mismo archivo

            inicializaPersona(persona, edad);
            string aux;
            //aux = Console.ReadLine();
            //persona.Edad = validarEdad(aux); //como estas en proyecto program no hace falta poner Program.ValidadEdad


            Console.WriteLine("Ingrese la edad");
            persona.Edad = int.Parse(Console.ReadLine());
            //Console.WriteLine(persona.Edad.ToString());
            Console.WriteLine("Ingrese el nombre");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("La persona se llama {0,50} y tiene {1,3} años ", persona.Nombre,persona.Edad);
            Console.ReadLine();
        }
        static void inicializaPersona(Persona persona,double edad)
        {
            edad =  persona.Edad; //casteo implicido

        }
        //static int validadEdad(string edad)
        //{
        //    int salida = -1;

        //    if (int.TryParse(edad, out salida))
        //        return salida;
        //    else
        //        salida = -1;
        //}
    }
}
