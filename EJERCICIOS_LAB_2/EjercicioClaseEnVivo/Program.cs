using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario();
            usuario1.CrearUsuario();
            //usuario2.CrearUsuario();

            Console.ReadKey();
        }
    }
}
