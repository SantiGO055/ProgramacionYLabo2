using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{
    public partial class FrmJueguito : Form
    {
        private int numero1;
        Thread t;
        public FrmJueguito()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero();
            Numero numero2 = new Numero();
            Numero numero3 = new Numero();
            Numero numero4 = new Numero();

            numero1.TxtMostrado = txtJug1;
            numero2.TxtMostrado = txtJug2;
            numero3.TxtMostrado = txtJug3;
            numero4.TxtMostrado = txtJug4;


        }

        private void btnJug1_Click(object sender, EventArgs e)
        {

        }
    }
}
