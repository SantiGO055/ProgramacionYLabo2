using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizza
    {
        private int cantidad;
        private string gusto;
        private string tipoCoccion;

        public Pizza(int cantidad, string gusto, string tipoCoccion)
        {
            this.cantidad = cantidad;
            this.gusto = gusto;
            this.tipoCoccion = tipoCoccion;
        }

        public static bool operator ==(Pizza pizzaA, Pizza pizzaB)
        {
            if (pizzaA != null)
            {
                return pizzaA.gusto == pizzaB.gusto && pizzaA.tipoCoccion == pizzaB.tipoCoccion;
            }
            return false;
        }
        public static bool operator !=(Pizza pizzaA, Pizza pizzaB)
        {
            return !(pizzaA==pizzaB);
        }

        public static bool operator +(Pizza pizzaA, Pizza pizzaB)
        {
            if (pizzaA == pizzaB)
            {
                pizzaA.cantidad += pizzaB.cantidad;
                return true;
            }
            else
                return false;
        }
    }
}
