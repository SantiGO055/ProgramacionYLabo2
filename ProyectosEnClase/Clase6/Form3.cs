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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCuarto frmCuarto = new FrmCuarto();
            frmCuarto.ShowDialog();
        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
