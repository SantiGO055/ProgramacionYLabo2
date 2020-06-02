using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PracticaInterface : IExplicita
    {
        bool IExplicita.Implementacion() //implemento la interfaz de manera explicita
        {
            return true;
        }

        public bool Implementacion()
        {
            return false;
        }
        //public bool Implementacion() //implemento la interfaz de manera implicita
        //{
        //    return true;
        //}
    }
}
