using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EjercicioRepasoViernes1Mayo
{
    public partial class Form1 : Form
    {
        private string usuario;
        private string contraseña;
        private bool cambiar = true;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;
            Form2 formLogueado = new Form2(usuario, contraseña);
            if (txtContraseña.Text == "asd123" && txtUsuario.Text == "pepito")
            {
                formLogueado.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no valido", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
