using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesHerenciaVehiculo
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected short cantidadMarchas;
        protected int cantidadPasajeros;
        protected Colores color;

        public short CantidadPuertas
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; }
        }
        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }
        public short CantidadRuedas
        {
            get { return this.cantidadRuedas; }
            set { this.cantidadRuedas = value; }
        }
        public Colores Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int CantidadPasajeros
        {
            get { return this.cantidadPasajeros; }
            set { this.cantidadPasajeros = value; }
        }


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color,int cantidadPasajerosr)
        {
            CantidadPasajeros = cantidadPasajeros;
            CantidadMarchas = cantidadMarchas;
            CantidadPuertas = cantidadPuertas;
            CantidadRuedas = cantidadRuedas;
            Color = color;
        }
        

    }
}
