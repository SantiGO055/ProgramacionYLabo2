using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase2
{

    public class Jugador
    {
        const int LIMITEDERECHA = 80;
        const int LIMITEABAJO = 20;


        const int DERECHA = 1;
        const int IZQUIERDA = 2;
        const int ABAJO = 3;
        const int ARRIBA = 4;


        public static int numeroJugadores;
        public string nombre;
        private int posicionX;
        private int posicionY;
        public int movimiento;
        public bool isAlive;



        public int vida;

        static Jugador()
        {
            numeroJugadores = 0;
        }

        
        public Jugador(string nombre,bool posicionDerecha)
        {
            Jugador.numeroJugadores++;
            this.vida = 100;
            this.nombre = nombre;
            this.isAlive = true;
            posicionX = 10;
            posicionY = 10;
            movimiento = DERECHA;
            if (posicionDerecha)
            {
                posicionX = 70;
                movimiento = IZQUIERDA;
            }

            pintar();
        }

        private void pintar()
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.Write("█");

        }

        public void Mover()
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.Write(" ");

            switch (movimiento)
            {
                case DERECHA:
                    if(posicionX == LIMITEDERECHA -1)
                    {
                        posicionX = 40;
                        vida--;
                    }
                    posicionX++;
                    break;

                case IZQUIERDA:
                    if (posicionX == 1)
                    {
                        posicionX = 40;
                        vida--;
                    }
                    posicionX--;
                    break;
                case ARRIBA:
                    if (posicionY == 1)
                    {
                        posicionY = 10;
                        vida--;
                    }
                    posicionY--;
                    break;
                case ABAJO:
                    if (posicionY == LIMITEABAJO - 1)
                    {
                        posicionY = 10;
                        vida--;
                    }
                    posicionY   ++;
                    break;

            }

            pintar();

        }
    }
}
