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

namespace FrmCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que deea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        //private double Operar(string numero1, string numero2, string operador)
        //{

        //}
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperar.Text = "";
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            double resultado;
            //Control control = btnConvertirABinario.Parent;
            //control.MouseClick

            if (lblResultado.Text != string.Empty)
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double resultado;
            int click = 0;
            //Control control = btnConvertirABinario.Parent;
            //control.MouseClick

            if (lblResultado.Text != string.Empty)
            {
                double.TryParse(lblResultado.Text, out resultado);
                lblResultado.Text = Numero.DecimalBinario(resultado);
            }

        }
        private void btnOperar_Click(object sender, EventArgs e)
        {

            if (this.txtNumero1.Text == string.Empty || this.txtNumero2.Text == string.Empty)
            {
                MessageBox.Show("ERROR! Revise los numeros y operador", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperar.Text).ToString();
            }

        }
    }
}
