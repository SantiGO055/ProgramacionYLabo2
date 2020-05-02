using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesHerenciaVehiculo
{
    public class Automovil : VehiculoTerrestre
    {
        protected int cantidadPasajeros;

		public int CantidadPasajeros
		{
			get { return this.cantidadPasajeros; }
			set { this.cantidadPasajeros = value; }
		}

		public Automovil(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas , Colores color, int cantidadPasajeros) :base(cantidadRuedas, cantidadPuertas, cantidadMarchas, color,cantidadPasajeros)
		{
			this.cantidadPasajeros = cantidadPasajeros;
			this.cantidadPuertas = cantidadPuertas;
			this.cantidadMarchas = cantidadMarchas;
			this.color = color;
		}

	}
}
