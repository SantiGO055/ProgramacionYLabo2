using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaEntidades
{
    class Staff : Persona
    {
        public Staff(string nombre):base(nombre)
        {
            this.Nombre = nombre;
        }
    }
}
