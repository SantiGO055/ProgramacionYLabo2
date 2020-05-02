using Clase_8_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Library
{
    class Accionista : Persona
    {
        private int _porcionAccionaria;

		public Accionista(string nombre, string apellido, int _porcionAccionaria) :base(nombre,apellido)
		{
			this.PorcionAccionaria = _porcionAccionaria;
		}
		public int PorcionAccionaria
		{
			get {
				return this._porcionAccionaria;
			}
			set {
				if (value >= 0 && value <= 100)
				this._porcionAccionaria = value; 
			}
		}

		public override string PosicionSocietaria()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Accionista con el: " + PorcionAccionaria + "%");
			return sb.ToString();
		}
		public static bool operator ==(Accionista a, Accionista b)
		{
			return (a.Nombre == b.Nombre) && (a.Apellido == b.Apellido) && (a.PorcionAccionaria == b.PorcionAccionaria);
		}
		public static bool operator !=(Accionista a, Accionista b)
		{
			return !(a == b);
		}


	}
}
