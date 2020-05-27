using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47Generics
{
    abstract class Equipo
    {
        string nombre;
        DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.Nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public DateTime FechaCreacion
        {
            get { return this.fechaCreacion; }
            set { this.fechaCreacion = value; }
        }



        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return (equipo1.nombre == equipo2.nombre) && (equipo1.fechaCreacion == equipo2.fechaCreacion);
        }
        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1== equipo2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Equipo: " + nombre + "Fundado en: " + fechaCreacion);
            return sb.ToString();

        }

    }
}
