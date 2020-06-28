using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public static class MetodoExtension //sirve para extender una clase dll que no tengo acceso para agregar una funcion
    {
        public static int HacerTrampa(this Numero numero, int valor)
        {
            int valorInicial = numero.Valor;
            numero.Valor = valor;

            return valorInicial;
        }
    }
}
