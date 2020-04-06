using System;

namespace Clase1
{
    class Program
    {


       
        static void Main(string[] args)
        {
            Persona.metodoestatico();
            Persona.huesos = 120;

            //Creando un objeto persona Tipo Referencia
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();
            persona1.Edad = 2;
            persona2.Edad = 5;
            

            //Creando una variable int Tipo Valor
            double edad = 25;

            //se envian los datos a método
            Program.InicializaPersona(persona1, edad);
            //el tipo Referencia fue modificado y el tipo valor No

            Console.WriteLine("ingrese la edad:");
            string aux;

            Console.Clear();
            Console.BackgroundColor = (ConsoleColor)4;
            Console.Title = "Ejercicio ";

            aux = Console.ReadLine();
            persona1.Edad = ValidarEdad(aux);

            Console.WriteLine("Ingrese el nombre:");
            persona1.Nombre = Console.ReadLine();

            Console.WriteLine(persona1.Edad.ToString());
            Console.WriteLine(persona1.Nombre);

            Console.WriteLine("La persona ingresada se llama " + persona1.Nombre + " y tiene " + persona1.Edad.ToString() + " años");
            Console.WriteLine("La persona ingresada se llama {0} y tiene  {1} años", persona1.Nombre, persona1.Edad);
            Console.WriteLine("La persona ingresada se llama {0,50} y tiene  {1,3,###.00} años", persona1.Nombre, persona1.Edad);

            Console.ReadLine();


        }


        static void InicializaPersona(Persona persona1, double edad )
        {

            // Explicito
            persona1.Edad = (int)edad ;

            // Implicito
            edad = persona1.Edad;
            
        }


        static int ValidarEdad(string edad)
        {
            int salida;
            int.TryParse(edad, out salida);
            return salida;
            

        }
    }
}

