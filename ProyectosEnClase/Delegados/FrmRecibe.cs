using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{

    public partial class FrmRecibe : Form
    {

        public FrmRecibe()
        {
            InitializeComponent();
        }

        private void FrmRecibe_Load(object sender, EventArgs e)
        {
            button1.Click += MuestroMensaje;
        }

        public void mostrarMensaje(string texto)
        {
            this.lblRecibe.Text = texto;
        }

        private void MuestroMensaje(object sender,EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button1":
                    button1.Click -= MuestroMensaje; // lo saco para que no se vuelva a clickear
                    button2.Click += MuestroMensaje; // lo agrego para que se pueda clickear
                    break;
                case "button2":
                    button2.Click -= MuestroMensaje; // lo saco para que no se vuelva a clickear
                    button3.Click += MuestroMensaje; // lo agrego para que se pueda clickear
                    break;
                case "button3":
                    button3.Click -= MuestroMensaje; // lo saco para que no se vuelva a clickear
                    button4.Click += MuestroMensaje; // lo agrego para que se pueda clickear
                    break;
                case "button4":
                    button4.Click -= MuestroMensaje; // lo saco para que no se vuelva a clickear
                    button1.Click += MuestroMensaje; // lo agrego para que se pueda clickear
                    break;

                default:
                    break;
            }
            MessageBox.Show("Soy el boton " + ((Button)sender).Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Click -= MuestroMensaje;
            //button2.Click += MuestroMensaje;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
