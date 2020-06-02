using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticaInterface cl = new PracticaInterface();
            Console.WriteLine(((IExplicita)cl).Implementacion()); //casteo objeto a iexplicita para poder acceder al metodo
            Console.WriteLine(cl.Implementacion()); //la diferencio de la otra no haciendola explicita sino implicita
            
            //uso una explicita por si tengo 2 metodos con mismo nombre, lo hago implicito si necesito diferenciarlas
            
        }
    }
}
