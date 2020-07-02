using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class Dato
    {
        public string nombre;
        public int edad;

        public Dato()
        {

        }
        public Dato(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
