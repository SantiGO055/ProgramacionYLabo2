using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesAlumnito
{
    public class EdadException : Exception
    {
		private int edad;
		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		public EdadException(int edad, string mensaje) : base(mensaje)
		{
			this.Edad = edad;
		}

	}
}
