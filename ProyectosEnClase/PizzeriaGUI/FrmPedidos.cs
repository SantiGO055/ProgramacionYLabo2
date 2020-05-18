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
    public partial class FrmPedidos : Form
    {
        public Pedido pedido;
        public Cliente cliente;
        public FrmPedidos(Cliente cliente)
        {
            InitializeComponent();
            this.pedido = cliente;
            StringBuilder sb = new StringBuilder();
            sb.Append("Cliente: " +cliente.nombre + " , " + cliente.apellido);
            lblClientePedido.Text = sb.ToString();
            

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            //FrmClientes frmClientes = new FrmClientes();

        }


        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void lstPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.pedido + new Pizza((int)(this.nmuCantidad.Value),this.cmbGusto.SelectedItem.ToString(), this.cmbCoccion.SelectedItem.ToString()))
            {
                this.pedido.horaIngreso = DateTime.Now; //
                
                MostrarListaDePizzas();
            }

            
        }

        private void MostrarListaDePizzas()
        {

            lstPedidosPorRealizar.Items.Clear();
            foreach (var item in this.pedido.pizzas)
            {
                StringBuilder sb = new StringBuilder();
                if (!(pedido.pizzas is null) && !(item is null))
                {
                    sb.Append(item.MostrarPizzas());
                    sb.AppendLine("");
                    lstPedidosPorRealizar.Items.Add(sb.ToString());
                    
                }
                this.Controls.Add(lstPedidosPorRealizar);

            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            //el resultado va a ser un objeto pedido cargado
            //new Pedido();

            this.pedido.horaIngreso = DateTime.Now;
            this.pedido.horaRetiro = DateTime.Now.AddSeconds(10);
            if (chkEnvia.Checked)
            {
                this.pedido.envia = true;
            }
            this.DialogResult = DialogResult.OK;

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblClientePedido_Click(object sender, EventArgs e)
        {

        }

        private void chkEnvia_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
