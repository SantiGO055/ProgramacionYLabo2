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
        private Cliente cliente;
        public FrmPedidos(Cliente cliente)
        {
            InitializeComponent();
            this.pedido = cliente;
                        
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            StringBuilder sb = new StringBuilder();
            sb.Append(frmClientes.cliente.nombre + " " + frmClientes.cliente.apellido);
            lblCliente.Text = sb.ToString();
        }


        private void btnAgregarPizzas_Click(object sender, EventArgs e)
        {

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
            
            if(this.pedido + new Pizza(this.nmuCantidad.Value,this.cmbGusto.SelectedItem.ToString(), this.cmbCoccion.SelectedItem.ToString()));
            
        }
        private void cargarPizzas()
        {
            this.lstPedidos.Items.Clear();
            foreach (var item in this.pedido.pizzas)
            {
                this.lstPedidos.Items.Add(item);
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            //el resultado va a ser un objeto pedido cargado
            //new Pedido();
            this.pedido = cliente;
            this.pedido.horaIngreso = DateTime.Now;
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
