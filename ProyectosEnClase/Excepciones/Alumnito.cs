using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesAlumnito
{
    public class Alumnito
    {
		private int edad;
		public string nombre;
		public string apellido;
		public int legajo;

		public Alumnito(int edad, string nombre, string apellido, int legajo)
		{
			this.Edad = edad;
			this.nombre = nombre;
			this.apellido = apellido;
			this.legajo = legajo;
		}

		public int Edad
		{
			get { return this.edad; }
			set {
				if (value < 16)
				{
					throw new EdadException(value, "El alumno no puede ser menor a 16 años");
				}
				this.edad = value;
			}
		}

	}
}
