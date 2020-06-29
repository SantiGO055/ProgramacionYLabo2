using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QueNoLlegueACero
{
    public partial class FrmPrincipal : Form
    {
        List<Thread> hilos;
        List<Numero> numeros;

        public FrmPrincipal()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            numeros = new List<Numero>();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            lblPuntos.Text = "0";
            btnEmpezar.Click -= btnEmpezar_Click;

            Numero numero1 = new Numero();
            Numero numero2 = new Numero();
            Numero numero3 = new Numero();
            Numero numero4 = new Numero();
            numeros.Add(numero1);
            numeros.Add(numero2);
            numeros.Add(numero3);
            numeros.Add(numero4);

            numero1.TxtMostrado = txtJug1;
            numero2.TxtMostrado = txtJug2;
            numero3.TxtMostrado = txtJug3;
            numero4.TxtMostrado = txtJug4;

            numero1.LlegueACero += perdi;
            numero2.LlegueACero += perdi;
            numero3.LlegueACero += perdi;
            numero4.LlegueACero += perdi;


            hilos.Add(new Thread(numero1.Descontar));
            hilos.Add(new Thread(numero2.Descontar));
            hilos.Add(new Thread(numero3.Descontar));
            hilos.Add(new Thread(numero4.Descontar));
            hilos.Add(new Thread(sumarPuntos));

            btnJug1.Click += numero1.Reset;
            btnJug1.Click += btnJug1_Click;

            btnJug2.Click += numero2.Reset;
            btnJug2.Click += btnJug2_Click;

            btnJug3.Click += numero3.Reset;
            btnJug3.Click += btnJug3_Click;

            btnJug4.Click += numero4.Reset;
            btnJug4.Click += btnJug4_Click;

            foreach (var item in hilos)
            {
                if (!item.IsAlive)
                    item.Start();
            }
            
        }
        

        private void btnJug1_Click(object sender, EventArgs e)
        {
            hilos[0].Abort();
            hilos[0] = new Thread(numeros[0].Descontar);
            hilos[0].Start();
        }
        private void btnJug2_Click(object sender, EventArgs e)
        {
            hilos[1].Abort();
            hilos[1] = new Thread(numeros[1].Descontar);
            hilos[1].Start();
        }
        private void btnJug3_Click(object sender, EventArgs e)
        {
            hilos[2].Abort();
            hilos[2] = new Thread(numeros[2].Descontar);
            hilos[2].Start();
        }
        private void btnJug4_Click(object sender, EventArgs e)
        {
            hilos[3].Abort();
            hilos[3] = new Thread(numeros[3].Descontar);
            hilos[3].Start();
        }

        private void perdi(object obj)
        {
            eliminarHilos(obj );
            MessageBox.Show("Perdiste");
            

        }

        private void sumarPuntos()
        {
            while (true)
            {
                if (lblPuntos.InvokeRequired)
                    lblPuntos.BeginInvoke((MethodInvoker)delegate ()
                   {
                       lblPuntos.Text = (int.Parse(lblPuntos.Text) + 1).ToString();
                   });
                else
                    lblPuntos.Text = (int.Parse(lblPuntos.Text) + 1).ToString();

                Thread.Sleep(15);
            }
            
        }
        

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            eliminarHilos(null);
        }

        private void eliminarHilos(object obj)
        {
            for(int  i= 0; i < hilos.Count;i++)
            {
                //No abortar al hilo que lanzo el evento
                if (hilos[i].IsAlive && (obj is null ||  ((Numero)obj).TxtMostrado.Name.Substring(6,1) != (i+1).ToString()))
                    hilos[i].Abort();
            }
        }

    }
}
