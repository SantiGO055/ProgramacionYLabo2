using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum ETipo
    {
        Aereo,
        Maritimo,
        Terrestre
    }
    public enum ECombustible
    {
        Nafta,
        Gas,
        Diesel,
        TraccionSangre
    }
    public abstract class Transporte
    {
        private ECombustible combustible;
        private ETipo tipo;
        private int cantidadMaxPasajeros;

        public Transporte(ECombustible combustible, ETipo tipo, int cantidadMaxPasajeros)
        {
            this.combustible = combustible;
            this.tipo = tipo;
            this.cantidadMaxPasajeros = cantidadMaxPasajeros;
        }

        public ECombustible Combustible
        {
            get { return combustible; }
            set { combustible = value; }
        }
        public ETipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int CantidadMaxPasajeros
        {
            get { return cantidadMaxPasajeros; }
            set { cantidadMaxPasajeros = value; }
        }

        

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Tipo de Combustible: " + Combustible);
            sb.AppendLine("");
            sb.Append("Tipo transporte: " + Tipo);
            sb.AppendLine("");
            sb.Append("Cantidad Max de pasajeros: " + CantidadMaxPasajeros);

            return sb.ToString();
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancar");
        }
        public abstract void Frenar();
    }
}
