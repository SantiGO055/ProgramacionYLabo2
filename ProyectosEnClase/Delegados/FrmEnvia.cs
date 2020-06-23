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
    public delegate void CargarMensaje(string palabra);
    public partial class FrmEnvia : Form
    {

        public event CargarMensaje EnviaMensaje;

        public FrmEnvia()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtEnviar.Text != string.Empty)
            {
                EnviaMensaje(txtEnviar.Text);
            }
        }
    }
}
