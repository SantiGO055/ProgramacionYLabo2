using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Autos auto1 = new Autos("asd123", 11222333);
            string informacionDeAuto;

            
            informacionDeAuto = (string)auto1; //de forma explicita transformo el auto en string, puedo llegar a peder datos
            //Console.WriteLine(auto1.GetInformacion());
            //auto1.SetInformacion(5);
            Estacionamiento estacionamiento3 = 10;
            

            Estacionamiento estacionamiento1 = new Estacionamiento("Sector A",5);
            Estacionamiento estacionamiento2 = new Estacionamiento("Sector B",10);

            Console.WriteLine(Estacionamiento.GenerarPrecio());
            Console.WriteLine(Estacionamiento.GenerarPrecio());
            Console.WriteLine(Estacionamiento.GenerarPrecio());
            Console.WriteLine(Estacionamiento.GenerarPrecio());
            Console.WriteLine(Estacionamiento.MostrarMensaje());
            Console.ReadKey();
        }
    }
}
