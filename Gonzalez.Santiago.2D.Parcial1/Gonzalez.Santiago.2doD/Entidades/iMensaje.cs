using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMensaje<T>
    {
        /*
        metodos y propiedades
        no deja implementar metodos ni propiedades

        */

        string MostrarMensaje();
        T AutoReferencia
        {
            get;
            set;
        }

    }
}
