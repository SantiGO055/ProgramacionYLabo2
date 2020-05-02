using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Velero : Transporte
    {
        private double precio;

        public Velero(ECombustible combustible, ETipo tipo, int cantidadMaxPasajeros, double precio) : base(combustible, tipo, cantidadMaxPasajeros)
        {
            this.Precio = precio;
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public override void Frenar()
        {
            Console.WriteLine("Guarda la vela y frena lentamente hasta tirar el ancla");
        }

    }
}
