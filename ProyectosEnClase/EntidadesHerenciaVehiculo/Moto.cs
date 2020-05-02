using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesHerenciaVehiculo
{
    public class Moto : VehiculoTerrestre
    {
        protected short cilindrada;


		public short Cilindrada
		{
			get { return this.cilindrada; }
			set { this.cilindrada = value; }
		}

		public Moto(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, cantidadMarchas, color, cantidadPasajeros)
		{
			this.cantidadRuedas = cantidadRuedas;
			this.cantidadPasajeros = cantidadPasajeros;
			this.cantidadPuertas = cantidadPuertas;
			this.cantidadMarchas = cantidadMarchas;
			this.color = color;
		}

	}
}
