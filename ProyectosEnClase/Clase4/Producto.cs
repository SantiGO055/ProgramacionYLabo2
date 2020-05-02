using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase4
{
    public class Producto
    {
        public string tipo;
        public float precio;
        public int cantidad;
        public string marca;
        public string fabricante;


        public void Ingresar()
        {
            this.tipo = "DEFECTO TIPO";
            this.marca = "MARCA MARCA";
            this.fabricante = "FABRI FABRICA";
            this.precio = 100;
            this.cantidad = 1;
        }

        public static bool operator == (Producto producto1, Producto producto2  )
        {
            return producto1.tipo == producto2.tipo && producto1.marca == producto2.marca && producto1.fabricante == producto2.fabricante;
        }


        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);

        }
        //  Producto producto1 = "Barbijo";
        public static implicit operator Producto(string tipo)
        {
            Producto aux = new Producto();
            aux.tipo = tipo;
            return aux;
        }

        //Console.WriteLine((string)producto1);
        public static explicit operator string(Producto prod)
        {
            string aux = " tipo:" + prod.tipo;
            aux += " precio:" + prod.precio.ToString();
            aux += " cantidad:" + prod.cantidad.ToString();
            aux += " marca:" + prod.marca;
            aux += " fabricante:" + prod.fabricante;
            
            return aux;
        }



        public static explicit operator int(Producto prod)
        {
            return prod.cantidad;
        }



        public static implicit operator Estante(Producto producto)
        {
            Estante estante = new Estante(1);
            if (estante + producto)
                return estante;
            return null;

        }


    }
}

