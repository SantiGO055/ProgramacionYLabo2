using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;

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


    }
}
