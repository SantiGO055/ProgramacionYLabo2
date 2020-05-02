using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Auto : Transporte
    {
        private int cantidadPuertas;

        public Auto(ECombustible combustible, ETipo tipo, int cantidadMaxPasajeros,int cantidadPuertas) : base(combustible,tipo,cantidadMaxPasajeros)
        {
            this.CantidadPuertas = cantidadPuertas;
        }

        public int CantidadPuertas
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; }
        }

        public override void Frenar()
        {
            Console.WriteLine("El conductor freno con freno de mano");
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad de puertas: " + this.cantidadPuertas);
            

            return sb.ToString(); 
        }
    }
}
