using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase4
{
    public class Estante
    {
        public Producto[] productos;

        public Estante(int cantidad)
        {
            this.productos = new Producto[cantidad];
        }
        public static Estante operator !(Estante estante)
        {
            if (estante is null)
                return new Estante(2);
            return null;
        }

        public static  bool  operator + (Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            { 
                if (estante.productos[i] == producto)
                {
                    estante.productos[i].cantidad += producto.cantidad;
                    return true;
                }
            }

            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] is null)
                {
                    estante.productos[i] = producto;
                    return true;
                }
            }
            return false ;
        }

        public static bool operator -(Estante estante, Producto producto)
        {
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                    return true;
                }
            }
            return false;
        }



    }
}
