using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzeria;

namespace PizzeriaGUI
{
    public partial class FrmPrincipal : Form
    {

        public Queue<Pedido> pedidos;
        public List<Cliente> clientes;
        public Cliente cliente;
        public FrmPrincipal()
        {
            InitializeComponent();
            //en este constructor instanciamos los objetos
            pedidos = new Queue<Pedido>();
            clientes = new List<Cliente>();
            //FrmPedidos frmPedidos = new FrmPedidos(cliente);
            //foreach (var item in clientes)
            //{
            //    if (!(item is null))
            //    {
            //        if (pedidoss + new Pizza(1, "muzzarella", "al horno")) ;
            //        item.
                    
                    
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }








        //foreach de clientes
        //prueba hardcodeo clientes



        //MessageBox.Show(this.clientes[0].nombre);

        //clientes.Remove(this.clientes[0]);
        //MessageBox.Show(this.clientes[0].nombre);





        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmAltaClientes = new FrmClientes();
            if (frmAltaClientes.ShowDialog() == DialogResult.OK)
            {
                this.clientes.Add(frmAltaClientes.cliente);
                lstClientes.Items.Clear();
            }

            foreach (var item in clientes)
            {
                lstClientes.Items.Add(item.MostrarCliente());

            }
        }

        private void btnRealizarPedido_Click_1(object sender, EventArgs e)
        {
            if (this.lstClientes.SelectedIndex != -1)
            {
                FrmPedidos frmPedido = new FrmPedidos(this.clientes[lstClientes.SelectedIndex]);

                if (frmPedido.ShowDialog() == DialogResult.OK)
                {
                    lstPedidosPendientes.Items.Clear();
                    this.pedidos.Enqueue(frmPedido.pedido);
                    foreach (var item in pedidos)
                    {
                        if (!(item.pizzas is null))
                        {

                            lstPedidosPendientes.Items.Add(MostrarPedidoEnLista());
                            timer1.Enabled = true;
                            

                        }
                    }
                    
                }
            }





        }

        public void EliminarPedidoDeLaCola()
        {
            foreach (var item in pedidos)
            {
                if (!(item.pizzas is null))
                {
                    if (DateTime.Now >= item.horaRetiro )
                    {
                        lstPedidosPendientes.Items.Remove(MostrarPedidoEnLista());
                        pedidos.Dequeue();
                        
                        //lstPedidosSalieron.Items.Add(MostrarPedidoEnLista());
                        break;
                    }
                }
            }
        }
        private string MostrarPedidoEnLista()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var itemPedidos in pedidos)
            {

                if (!(itemPedidos is null))
                {
                    foreach (var itemPizzas in itemPedidos.pizzas)
                    {
                        if (!(itemPizzas is null))
                        {
                            sb.Append(itemPedidos.MostrarPedido()); // VERIFICAR POR QUE NO IMPRIME CON ENTER!!!!!!!!!!!!!!!!!!!!!!!!!
                        }
                        
                    }
                    
                    //sb.Append("Cliente: " + clienteMuestro.nombre + clienteMuestro.apellido);
                    //sb.Append(", " + );

                    sb.Append(" - " + itemPedidos.horaIngreso.ToString("hh:mm:ss"));
                    sb.AppendLine("");
                }
            }
            return sb.ToString();

        }


        private void lstPedidosSalieron_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPedidosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            EliminarPedidoDeLaCola();
        }
    }
}
