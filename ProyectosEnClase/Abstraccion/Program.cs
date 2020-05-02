using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto(ECombustible.Gas, ETipo.Terrestre, 3, 3);
            miAuto.Mostrar();

            List<Transporte> transportes = new List<Transporte>();

            transportes.Add(new Auto(ECombustible.Gas, ETipo.Terrestre, 4, 1));

            foreach (Transporte item in transportes)
            {
               Console.Write( item.Mostrar());
            }
            Console.ReadKey();
        }
    }
}
