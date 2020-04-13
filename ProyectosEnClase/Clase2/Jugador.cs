using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase3
{
    
    public class Jugador
    {
        const int DERECHA = 6;
        const int IZQUIERDA = 4;
        const int ABAJO = 2;
        const int ARRIBA = 8;


        public static int numeroJugadores;
        public string nombre;
        public int vida;
        private int posicionX;
        private int posicionY;
        public int movimiento;
        public bool isAlive;
        static Jugador() // constructor estatico o de clase. No recibe parametros
        {
            numeroJugadores = 0;
        }

        
        

        public Jugador(string nombre, bool posicionDerecha) //constructor de instancia primero se hace el this() y despues lo que esta dentro, se usa para ahorrar codigo
        {
            Jugador.numeroJugadores++;
            this.vida = 100;
            this.nombre = nombre; // es como hardcodear el nombre, cada vez que creo un jugador va a tener ese nombre
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
            Console.WriteLine("█");

        }
        public void mover(int movimiento)
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.Write(" ");
            switch (movimiento)
            {
                case DERECHA:
                    posicionX++;
                    break;
                case IZQUIERDA:
                    posicionX--;
                    break;
                case ARRIBA:
                    posicionY++;
                    break;
                case ABAJO:
                    posicionY--;
                    break;
            }
        }
    }
}