using System.Text;
using System;
using System.Linq;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto()
        {
            this.marca = "MARCA NO INGRESADA";
            this.codigoDeBarra = "Codigo no ingresado";
            this.precio = -1;
        }
        public Producto(string marca) : this()
        {
            this.marca = marca;
        }
        public Producto(string marca, string codigo) : this(marca)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
        }
        public Producto(string marca, string codigo, float precio) : this(marca, codigo)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: " + this.marca);

            return sb.ToString();
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo de barras: " + producto.codigoDeBarra);
            sb.AppendLine("Marca: " + producto.marca);
            sb.AppendLine("Precio: " + producto.precio);

            return sb.ToString();
        }

        public static explicit operator string(Producto producto) //casteo manualmente a string
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto productoA, Producto productoB)
        {
            return (productoA.marca == productoB.marca) && (productoA.codigoDeBarra == productoB.codigoDeBarra);
            //bool iguales = false;
            //if (productoA.marca == productoB.marca)
            //{
            //    if (productoA.codigoDeBarra == productoB.codigoDeBarra)
            //    {
            //        iguales = true;
            //    }
            //    else
            //    {
            //        iguales = false;
            //    }

            //}
            //else
            //{
            //    iguales = false;
            //}
        }
        public static bool operator !=(Producto productoA, Producto productoB)
        {
            return !(productoA == productoB);
        }
        public static bool operator ==(Producto productoA, string marcaProducto)
        {
            return productoA.marca == marcaProducto;
        }
        public static bool operator !=(Producto productoA, string marcaProducto)
        {
            return !(productoA == marcaProducto);
        }


    }
}
