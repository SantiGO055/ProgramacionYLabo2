using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LIMITEDERECHA = 80;
            const int DERECHA = 6;
            const int IZQUIERDA = 4;
            const int ABAJO = 2;
            const int ARRIBA = 8;

            double numero = 0;
            Jugador.numeroJugadores = 0;
            Jugador jugador1 = new Jugador("Aragorn",true); //no va a existir el objeto hasta que el programa corra. Para crearlo va nombre de la clase espacio y nombre del objeto
            //jugador1.mover(); //jugador 1 tiene metodo mover pero si jugador1 nunca se hizo new no va a tener mover por que no existe
            

            ConsoleKeyInfo consoleKeyInfo;
            #region Hacer Cancha
            //█ -> ALT + 219
            for (int i = 1; i < 20; i++)
            {
                Console.CursorLeft = 1;
                Console.CursorTop = i;
                Console.WriteLine("█");
                Console.CursorLeft = 80;
                Console.CursorTop = i;
                Console.WriteLine("█");

            }

            for (int i = 1; i < 80; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = 1;
                Console.WriteLine("█");
                Console.CursorLeft = i;
                Console.CursorTop = 20;
                Console.WriteLine("█");

            }
            #endregion
            do
            {
                while (!Console.KeyAvailable)
                {
                    numero = 0;
                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            jugador1.movimiento = ARRIBA;
                            break;
                        case ConsoleKey.DownArrow:
                            jugador1.movimiento = ABAJO;
                            break;
                        case ConsoleKey.LeftArrow:
                            jugador1.movimiento = IZQUIERDA;
                            break;
                        case ConsoleKey.RightArrow:
                            jugador1.movimiento = DERECHA;
                            break;
                    }

                    jugador1.mover(consoleKeyInfo);
                    Thread.Sleep(100);
                }

                
                consoleKeyInfo = Console.ReadKey();
                Console.WriteLine(numero);
            } while (consoleKeyInfo.KeyChar != 27);
            
        }
    }
}
