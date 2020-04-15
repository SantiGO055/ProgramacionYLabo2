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
    public partial class Form1 : Form
    {

        string informacion = "Hola mundo";

        Cliente[] cliente;
        public Form1()
        {
            InitializeComponent();
            //en este constructor instanciamos los objetos

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = informacion;
        }
    }
}
