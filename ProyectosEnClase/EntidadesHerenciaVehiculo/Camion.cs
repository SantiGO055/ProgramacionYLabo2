using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesHerenciaVehiculo
{
    public class Camion : VehiculoTerrestre
    {
        
        
        protected int pesoCarga;


        
        public int PesoCarga
        {
            get { return this.pesoCarga; }
            set { this.pesoCarga = value; }
        }

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas, color, cantidadPasajeros)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.color = color;
        }

    }
}
