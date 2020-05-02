using System;
using System.Collections.Generic;
using System.Text;

namespace TPClase5Clases
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }
        public Cliente(string nombre, string apellido):this(nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Cliente(string nombre, string apellido, string domicilio):this(nombre,apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
        }
    }
}
