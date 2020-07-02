using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            //public event SinCombustible SinCombustible;
            List<Thread> hilos = new List<Thread>();
            List<Automovil> autitos = new List<Automovil>();
            Automovil autito1 = new Automovil(5, 1);
            autitos.Add(autito1);
            autito1.SinCombustibleDelegadoAsigno(new SinCombustible(autito1.SinCombustiblee));
            autito1.Andar(6);
            Console.WriteLine();
            //sinCombuu.Invoke("Te quedaste sin combustible capo, te avise");
            //sinCombuu += SinCombustiblee;
            //autito1.SinCombustible += autito1.SinCombustiblee;

            
            Console.ReadKey();
        }

    }
}
