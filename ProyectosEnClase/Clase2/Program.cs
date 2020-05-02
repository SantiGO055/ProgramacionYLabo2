using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Clase2
{
    class Program
    {
        const int LIMITEDERECHA = 80;
        const int LIMITEABAJO = 20;

        const int DERECHA = 1;
        const int IZQUIERDA = 2;
        const int ABAJO = 3;
        const int ARRIBA = 4;


        static void Main(string[] args)
        {

            
            Jugador.numeroJugadores = 0;
            Jugador[] jugadores = new Jugador[4];
            
            //   Jugador jugador2 = new Jugador("Lara", true);
            ConsoleKeyInfo consoleKeyInfo;

            #region Hacer Cancha

            //█ --> alt + 219   

            for (int i = 1; i < LIMITEABAJO; i++)
            {
                Console.CursorLeft = 1;
                Console.CursorTop = i;
                Console.Write("█");
                Console.CursorLeft = LIMITEDERECHA;
                Console.CursorTop = i;
                Console.Write("█");
            }

            for (int i = 1; i <= LIMITEDERECHA; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = 1;
                Console.Write("█");
                Console.CursorLeft = i;
                Console.CursorTop = LIMITEABAJO;
                Console.Write("█");
            }

            #endregion


            do
            {

                
                while (!Console.KeyAvailable)
                {
                    foreach (Jugador jugador in jugadores)
                    {
                        if(jugador != null)
                            jugador.Mover();
                    }
                    //using System.Threading
                    Thread.Sleep(100);

                }
                
                consoleKeyInfo = Console.ReadKey();

                if(consoleKeyInfo.Key == ConsoleKey.N)
                {
                    if(Jugador.numeroJugadores < jugadores.Length)
                    {
                            jugadores[Jugador.numeroJugadores] = new Jugador("Jugador " + (Jugador.numeroJugadores + 1), false);
                     
                    }
                        
                }

                foreach (Jugador jugador in jugadores)
                {

                    #region Movimiento
                    if (jugador != null)
                    {
                        //ctrl +K+d
                        switch (consoleKeyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
                                jugador.movimiento = ARRIBA;
                                break;

                            case ConsoleKey.DownArrow:
                                jugador.movimiento = ABAJO;
                                break;

                            case ConsoleKey.LeftArrow:
                                jugador.movimiento = IZQUIERDA;
                                break;

                            case ConsoleKey.RightArrow:
                                jugador.movimiento = DERECHA;
                                break;
                        }

                    }
#endregion

                }
            } while (consoleKeyInfo.KeyChar != 27);


        }
    }
}
