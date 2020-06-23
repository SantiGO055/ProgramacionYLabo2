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
    
    public partial class FrmPrincipal : Form
    {
        FrmRecibe frmRecibe;



        public FrmPrincipal()
        {
            InitializeComponent();
            frmRecibe = new FrmRecibe();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmEnvia frmEnvia = new FrmEnvia();
            frmEnvia.EnviaMensaje += frmRecibe.mostrarMensaje;
            frmEnvia.EnviaMensaje += new CargarMensaje( FrmEnvia_EnviaMensaje); // crep un nuevo delegado y le paso el metodo, lo asigno al evento
            
            frmEnvia.Show();
            //btnEnviar.Click -= btnEnviar_Click; //
        }

        private void FrmEnvia_EnviaMensaje(string palabra)
        {
            MessageBox.Show(palabra);
        }

        private void btnRecibe_Click(object sender, EventArgs e)
        {

            frmRecibe.Show();
            
        }

        private void btnJueguito_Click(object sender, EventArgs e)
        {
            FrmJueguito frmJueguito = new FrmJueguito();
            frmJueguito.Show();
        }
    }
}
