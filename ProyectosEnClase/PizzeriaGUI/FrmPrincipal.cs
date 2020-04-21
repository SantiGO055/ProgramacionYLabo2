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
        
        public List<Pedido> pedidos;
        public List<Cliente> clientes;
        public FrmPrincipal()
        {
            InitializeComponent();
            //en este constructor instanciamos los objetos
            pedidos = new List<Pedido>();
            clientes = new List<Cliente>();
            Pizza pizza;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            




            //foreach de clientes
           //prueba hardcodeo clientes
            //clientes.Add(new Cliente("pepe"));
            //clientes.Add(new Cliente("maria"));
            //clientes.Add(new Cliente("juanita"));


            //MessageBox.Show(this.clientes[0].nombre);

            //clientes.Remove(this.clientes[0]);
            //MessageBox.Show(this.clientes[0].nombre);
            
            

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //this.clientes lista de clientes
            if (this.lstClientes.SelectedIndex != -1)
            {
                FrmPedidos frmPedido = new FrmPedidos(this.clientes[lstClientes.SelectedIndex]);
                if (frmPedido.ShowDialog() == DialogResult.OK)
                    this.pedidos.Add(frmPedido.pedido);
            }

        }
    }
}
