using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            //SHIFT + ALT selecciono varias lineas con las flechitas
            Producto[] arrayDeProductos = new Producto[5];

            for (int i = 0; i < arrayDeProductos.Length; i++)
            {
                arrayDeProductos[i] = new Producto();
                arrayDeProductos[i].IngresarProducto();
            }

        }
    }
}
