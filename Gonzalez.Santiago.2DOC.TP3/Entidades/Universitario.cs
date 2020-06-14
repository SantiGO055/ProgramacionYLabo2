using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;


        public Universitario(int legajo, string nombre, string apellido, ENacionalidad nacionalidad, int dni) :
            base(nombre, apellido, nacionalidad, dni)
        {
            this.Legajo = legajo;
        }


        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("LEGAJO: " + this.Legajo);
            return sb.ToString();
        }
        protected abstract string ParticiparEnClase();

        public static bool operator ==(Universitario univ1, Universitario univ2)
        {
            return !ReferenceEquals(univ1, null) && !ReferenceEquals(univ2, null) && univ1.GetType() == univ2.GetType() && (univ1.DNI.Equals(univ2.DNI) || univ1.legajo.Equals(univ2.legajo));
            
        }
        public static bool operator !=(Universitario univ1, Universitario univ2)
        {
            return !(univ1 == univ2);
        }

    }
}
