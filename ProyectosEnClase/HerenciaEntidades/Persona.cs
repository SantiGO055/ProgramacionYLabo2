using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaEntidades
{
    public class Persona
    {
		protected string apellido;

		public string Nombre { get; set; }


		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string MostrarNombre()
		{

			return this.Nombre + " " + this.apellido;
		}

		public Persona(string nombre)
		{
			this.Nombre = nombre;
		}

		
	}
}
