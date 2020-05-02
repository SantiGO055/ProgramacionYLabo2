using System;
using System.Collections.Generic;
using System.Text;

namespace TPClase5Clases
{
    class Pedido
    {
        private int envia;
        private int horaIngreso;
        private int horaRetiro;
        private string pizzas;

        
        public Pedido(int envia)
        {
            this.envia = envia;
        }
        public Pedido(int horaIngreso,int envia):this(envia)
        {
            this.horaIngreso = horaIngreso;
            this.envia = envia;
        }
        public Pedido(int horaIngreso,int envia,int horaRetiro):this(envia,horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.envia = envia;
            this.horaRetiro = horaRetiro;
        }
        public Pedido(int horaIngreso, int envia, int horaRetiro,string pizzas):this(envia, horaIngreso,horaRetiro)
        {
            this.horaIngreso = horaIngreso;
            this.envia = envia;
            this.horaRetiro = horaRetiro;
            this.pizzas = pizzas;
        }

        //public static bool operator +()
        //{

        //}
    }
}
