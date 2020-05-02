using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaEntidades
{
    internal class Alumno : Persona
    {

        public Alumno(string nombre):base("alumno")
        {
            this.Nombre = nombre;
        }
        
    }
}
