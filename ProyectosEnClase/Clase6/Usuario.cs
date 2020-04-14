using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    public class Usuario
    {
        string nombre;
        string apellido;
        double dni;

        public Usuario(string nombre, string apellido, double dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido: " + apellido);
            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("DNI: " + dni);

            return sb.ToString();
        }
    }
}
