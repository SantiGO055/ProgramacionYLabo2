using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Cliente
    {
        public string nombre;
        public string apellido;
        public string domicilio;


        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }
        public Cliente(string nombre, string domicilio) : this(nombre)
        {
            this.domicilio = domicilio;
        }
        public Cliente(string nombre, string apellido,string domicilio) : this(nombre, domicilio)
        {
            this.apellido = apellido;
        }
        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("" + nombre);
            sb.Append(", " + apellido);
            return sb.ToString();
        }

    }
}
