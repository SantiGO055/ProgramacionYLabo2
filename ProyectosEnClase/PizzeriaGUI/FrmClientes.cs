using System;
using System.Collections;
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
    public partial class FrmClientes : Form
    {
        //con el evento tick coloco un timer voy sacando pedidos cada cierto tiempo

        public Cliente cliente;
        public FrmClientes()
        {
            InitializeComponent();
            

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
        }
        private bool ValidarCampos()
        {
            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtDomicilio.Text == string.Empty)
            {
                MessageBox.Show("Complete los campos nombre, apellido y domicilio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos() == true)
            {
                this.cliente = new Cliente(txtNombre.Text,txtApellido.Text,txtDomicilio.Text);
                this.DialogResult = DialogResult.OK;
            }
            //for de clientes
            //FrmPrincipal.clientes
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FrmPrincipal.ActiveForm.Activate();
            //this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
