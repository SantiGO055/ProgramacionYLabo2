using System;
using System.Linq;

namespace ClaseRepaso
{
    public class Estacionamiento
    {
        private string nombreEstacionamiento;
        private Autos[] arrayDeAutos;
        private double precioPorAuto;
        private static Random numeroAleatorio;


        public Estacionamiento(string estacionamiento, int capacidadEstacionamiento) : this(capacidadEstacionamiento)
        {
            this.nombreEstacionamiento = estacionamiento;
        }

        private Estacionamiento(int capacidadEstacionamiento)
        {
            arrayDeAutos = new Autos[capacidadEstacionamiento];  //el tamaño que tendra el array, el new es del array y no de la clase Auto
            this.precioPorAuto = Estacionamiento.GenerarPrecio(); //genero un precio random para el estacionamiento
        }

        static Estacionamiento()
        {
            //objeto de la clase random
            numeroAleatorio = new Random(); //como caracteristica el constructor estatico se ejecuta una sola vez en todo el programa cuando se usa por primera vez esta clase
        }

        public static int GenerarPrecio()
        {
            return numeroAleatorio.Next(100, 300); //min,max
        }
        public static string MostrarMensaje()
        {
            return "Hola Mundo";
        }

        public static bool operator ==(Estacionamiento estacionamiento, Autos auto)
        {
            return estacionamiento.arrayDeAutos.Contains(auto); //devuelve true si esta adentro y false si esta afuera

            //bool esta = false;
            //buscar si el auto esta en el estacionamiento mediante el array de autos
            //foreach (Autos auxAuto in estacionamiento.arrayDeAutos) //el foreach hace una copia en una variable auxiliar
            //{
            //    if (!(auxAuto is null))
            //    {
            //        if (estacionamiento.arrayDeAutos == auto)
            //        {
            //            esta = true;
            //        }
            //    }

            //}
            //return esta;

            //for (int i = 0; i < estacionamiento.arrayDeAutos.Length; i++)
            //{
            //    if (!(estacionamiento.arrayDeAutos[i] is null))
            //    {
            //        if (estacionamiento.arrayDeAutos[i] == auto)
            //        {
            //            esta = true;
            //        }

            //    }
            //}
            //return esta;

        }
        public static bool operator !=(Estacionamiento estacionamiento, Autos auto)
        {
            return !(estacionamiento == auto); //como ya definimos el == en la sobrecarga de arriba lo reutilizamos
        }

        public static bool operator +(Estacionamiento estacionamiento, Autos auto)
        {
            bool agrego = false;
            if (estacionamiento != auto)
            {
                for (int i = 0; i < estacionamiento.arrayDeAutos.Length; i++)
                {
                    if (estacionamiento.arrayDeAutos[i] is null) //si no hay ningun auto y hay lugar
                    {
                        estacionamiento.arrayDeAutos[i] = auto; //agrego el auto adentro
                        agrego = true;
                        break;
                    }
                }
            }
            return agrego;
        }

        public static implicit operator Estacionamiento(int capacidad) //casteo manualmente a string
        {
            return new Estacionamiento(capacidad);
        }

    }
}
