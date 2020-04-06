using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            Jugador jugador1 = new Jugador(); //no va a existir el objeto hasta que el programa corra. Para crearlo va nombre de la clase espacio y nombre del objeto
            jugador1.mover(); //jugador 1 tiene metodo mover pero si jugador1 nunca se hizo new no va a tener mover por que no existe
            
            ConsoleKeyInfo consoleKeyInfo;

            do
            {
                numero = 0;
                
                
                while (!Console.KeyAvailable)
                {
                    numero++;
                }

                
                consoleKeyInfo = Console.ReadKey();
                Console.WriteLine(numero);
            } while (consoleKeyInfo.KeyChar != 27);
        }
    }
}
