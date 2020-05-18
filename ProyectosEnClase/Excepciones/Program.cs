using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ExcepcionesAlumnito
{
    public class Program
    {
        static void Main(string[] args)
        {
            int edadAux;
            Alumnito a1 = null;
            try
            {
                Console.WriteLine("Ingrese edad: ");
                edadAux = int.Parse(Console.ReadLine());
                a1 = new Alumnito(edadAux, "pepe", "gonzalez", 456);
                Console.WriteLine(a1.Edad + a1.nombre + a1.apellido + a1.legajo);
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            catch (EdadException ed)
            {
                Console.WriteLine(ed.Message);
            }

            finally
            {
                
                Console.ReadKey();
            }
            


        }
    }
}
