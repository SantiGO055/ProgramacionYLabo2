using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //this.lstViveCon.SelectedItem;
            
            double dni;

            if (Double.TryParse((this.txtDni.Text),out dni))
            {
                Usuario usuario = new Usuario(this.txtNombre.Text, this.txtApellido.Text, dni);
                this.lblSalida.Text = usuario.Mostrar();
            }
            else
            {
                MessageBox.Show("Ocurrio un error!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load"); //aca seteamos los por defectos
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cerrar alguna conexion o archivo abierto
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //preguntamos esta seguro que desea salir?
            if (MessageBox.Show("Esta seguro que desea cerrar el programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSegundo frmSegundo = new FrmSegundo();
                if( frmSegundo.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Ok");
                }
            frmSegundo.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frmTercero = new Form3();
            if (frmTercero.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Ok");
            }
            frmTercero.ShowDialog();
        }
    }
}
