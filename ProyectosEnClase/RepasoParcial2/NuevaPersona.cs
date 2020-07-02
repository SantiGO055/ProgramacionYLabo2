using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoParcial2
{
    public partial class NuevaPersona : Form
    {
        int numeroIncremental = 0;
        private List<Persona> miListaPersona;
        public NuevaPersona(Form1 frm1)
        {
            InitializeComponent();
            //miListaPersona = frm1.ListaPersona;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //int dni;
            //dni = int.Parse(txtDni.Text);
            //Persona miPersona = new Persona(numeroIncremental++, dni);
            //miListaPersona.Add(miPersona);
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
