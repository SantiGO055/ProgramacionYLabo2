using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimerForm frmPrimero = new PrimerForm();
            //frmPrimero.Show;

            Console.ReadKey();
            //Estante estante = new Estante(5);
            //int i;
            //for ( i = 0; i < estante.productos.Length; i++)
            //{
            //    Producto producto = new Producto();
            //    producto.Ingresar();
            //    if (estante + producto)
            //        Console.WriteLine("Se agregó correctamente");
            //}
            //Producto prodVacio = new Producto();
            //prodVacio.fabricante = "Lucas";
            //prodVacio.marca = "Segunda Mano";
            //prodVacio.tipo = "Barbijo";
            //prodVacio.precio = 250.99f;
            //prodVacio.cantidad = 0;
            //bool a = estante - prodVacio;
            //bool b = estante - (new Producto());
            //Estante estanteA = prodVacio;

            //Producto[,] productosEnEstanteria;
            //productosEnEstanteria = new Producto[4, 5];

            //int j;
            //for ( i = 0; i < 4; i++)
            //{
            //    for (j = 0; j < 5; j++)
            //    {
            //        productosEnEstanteria[i, j] = NuevoProducto();
            //    }
            //}

            
            //Producto producto1 = (Producto)"Barbijo";

            //Console.WriteLine((string)producto1);

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("");


        }
        static Producto NuevoProducto()
        {
            Producto prodVacio = new Producto();
            prodVacio.fabricante = "Lucas";
            prodVacio.marca = "Segunda Mano";
            prodVacio.tipo = "Barbijo";
            prodVacio.precio = 250.99f;
            prodVacio.cantidad = 0;

            return prodVacio;
        }
    }
}
