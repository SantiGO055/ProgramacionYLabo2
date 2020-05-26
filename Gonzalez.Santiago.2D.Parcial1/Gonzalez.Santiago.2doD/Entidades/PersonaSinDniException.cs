using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaSinDniException : Exception
    {
        public PersonaSinDniException(string mensaje, Exception ex) : base(mensaje,ex)
        {

        }
        public PersonaSinDniException(string mensaje) : base(mensaje)
        {

        }
    }
}
