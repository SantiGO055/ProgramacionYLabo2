using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException()
        {

        }
        public DniInvalidoException(string mensaje) : base(mensaje)
        {

        }

        public DniInvalidoException(Exception e, string message) : base(message, e)
        {

        }
    }
}
