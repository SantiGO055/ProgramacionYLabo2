using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    public class Pedido
    {
        public bool envia;
        public DateTime horaIngreso;
        public DateTime horaRetiro;
        public Pizza[] pizzas; //coleccion de pizzas
        private Cliente cliente;
        //agregar 1 cliente solo



        private Pedido()
        {
            this.pizzas = new Pizza[8];  //el tamaño que tendra el array, el new es del array y no de la clase Auto
        }
        //constructor de pedido que recibe un cliente
        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
            this.pizzas = new Pizza[8];
        }

        public Pedido(bool envia)
        {
            this.envia = envia;
        }
        public Pedido(bool envia, DateTime horaIngreso) : this(envia)
        {
            this.envia = envia;
            this.horaIngreso = horaIngreso;
        }
        public Pedido(DateTime horaIngreso, bool envia, DateTime horaRetiro) : this(envia, horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.horaRetiro = horaRetiro;
            this.envia = envia;
        }


        public static implicit operator Pedido(Cliente cliente)
        {
            Pedido aux = new Pedido(cliente);
            return aux;
        }
        public static bool operator +(Pedido pedido, Pizza pizza)
        {
            for (int i = 0; i < pedido.pizzas.Length; i++)
            {
                //buscar en array de pizzas si la pizza que llega existe
                if (pedido.pizzas[i] + pizza)
                {
                    return true;
                }

            }
            //agregar la pizza en el 
            for (int i = 0; i < pedido.pizzas.Length; i++)
            {
                if (pedido.pizzas[i] is null)
                {
                    pedido.pizzas[i] = pizza;
                    return true;
                }
            }
            return true;

        }
        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();
            
            
            foreach (var item in pizzas)
            {
                if (!(item is null))
                {
                    sb.Append("Pedido de: " + this.cliente.nombre + ", " + this.cliente.apellido + ", " + this.cliente.domicilio + ": .");
                    sb.Append(item.MostrarPizzas());
                    sb.AppendFormat("");
                    return sb.ToString();
                }
                
            }


            return sb.ToString();
            //for (int i = 0; i < cliente.Count ; i++)
            //{
            //    if (!(cliente is null)) //validar si el cliente esigual al pedido
            //{
            //    }
            //}
            //foreach (var item in pedidos)
            //{
            //    sb.Append("Pedido 1: " + item.cliente.nombre + item.cliente.apellido);

            //    return sb.ToString();
            //}
        }
    }
}
