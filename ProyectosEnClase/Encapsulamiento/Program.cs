using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Pepe", "Zaraza", 21, 157);
            Alumno alumno2 = new Alumno("Juan", "Chavo", 22, 1877);

            alumno1.GetNombre();
            Alumno.GetUnNombre(alumno1);

            string miAuxiliar = string.Empty;
            miAuxiliar = alumno1.Nombre; //si esta a la derecha hace un get, si esta a la izquierda es un set
            alumno2.Nombre = "Lucas";
            //validar en metodos estaticos
            Libro libro1 = new Libro();
            Console.WriteLine(libro1[0]);
            Console.WriteLine(libro1[3]);
            libro1[-3] = "pagina 5";
            libro1[1] = "pagina pepito 1";

            Console.ReadKey();

    }
    }
}
