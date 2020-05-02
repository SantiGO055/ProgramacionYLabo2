using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesHerenciaVehiculo;
namespace HerenciaVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre auto = new Automovil(4, 4, 5,Colores.Rojo, 4);
            Console.ReadKey();
            

        }
    }
}
