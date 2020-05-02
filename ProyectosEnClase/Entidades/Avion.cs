using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Avion : Transporte
    {
        private bool vuelosInternacionales;

        public Avion(ECombustible combustible, ETipo tipo, int cantidadMaxPasajeros, bool vuelosInternacionales) : base(combustible, tipo, cantidadMaxPasajeros)
        {
            this.VuelosInternacionales = vuelosInternacionales;
        }


        public bool VuelosInternacionales
        {
            get { return this.vuelosInternacionales; }
            set { this.vuelosInternacionales = value; }
        }

        public override void Frenar()
        {
            Console.WriteLine("Baja revoluciones  hasta a pista y frenar");
        }
    }
}
