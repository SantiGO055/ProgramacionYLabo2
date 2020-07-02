using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp6
{
    class Persona
    {
        decimal temperatura;
        long dni;
        string nombre;

        public decimal Temperatura { get { return temperatura; } set { this.temperatura = value; } }

        public long Dni { get { return dni; } set { this.dni = value; } }

        public string Nombre { get { return nombre; } set { this.nombre = value; } }

        public Persona(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public override string ToString()
        {
            return this.nombre + " - " + this.temperatura.ToString();
        }

    }
}
