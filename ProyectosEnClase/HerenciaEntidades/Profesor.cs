using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaEntidades
{
    internal sealed class Profesor : Staff //heredo de persona
    {
        int codigoMateria;
        public Profesor(string nombre) : base(nombre)
        {
            this.codigoMateria = 0;
        }

        public int CodigoMateria
        {
            get { return codigoMateria; }
            set { codigoMateria = value; }
        }

        public new string MostrarNombre()
        {
            return "";
        }
        public string ModificarNombre(Profesor p,string nombre)
        {
            
            return p.Nombre;
        }

    }

}
