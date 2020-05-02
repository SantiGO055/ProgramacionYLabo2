using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Carreta : Transporte
    {
        private int cantidadCaballos;

        public Carreta(ECombustible combustible, ETipo tipo, int cantidadMaxPasajeros, int cantidadCaballos) : base(combustible, tipo, cantidadMaxPasajeros)
        {
            this.CantidadCaballos = cantidadCaballos;
        }

        public int CantidadCaballos
        {
            get { return this.cantidadCaballos; }
            set { this.cantidadCaballos = value; }
        }
        public override void Frenar()
        {
            Console.WriteLine("Descender hasta a pista y frenar");
        }

    }
}
