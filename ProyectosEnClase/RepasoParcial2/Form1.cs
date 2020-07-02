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

namespace RepasoParcial2
{
    public delegate void AtencionTemperatura(object o);
    public delegate void AnalizarPersona(Persona p);
    public partial class Form1 : Form
    {
        public Queue<Persona> colaDePersonas;
        public Queue<Persona> colaDeContagiados;
        public Persona persona;
        public int numeroAumenta = 0;
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        Random temperaturaRandom = new Random();
        public event AnalizarPersona contagiado;
        public event AtencionTemperatura proximo;
        public Form1()
        {
            InitializeComponent();
            colaDePersonas = new Queue<Persona>();
            colaDeContagiados = new Queue<Persona>();
            contagiado += Contagiado;
            proximo += LlamarProximo;
            t1 = new Thread(LlamarProximo);
            t2 = new Thread(LlamarProximo);
            t3 = new Thread(LlamarProximo);
            t4 = new Thread(LlamarProximo);
            t5 = new Thread(LlamarProximo);
        }

        public int TemperaturaRandom()
        {
            return temperaturaRandom.Next(1, 39);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Atender(TextBox txt)
        {
            Persona aux = colaDePersonas.Dequeue();
            aux.Temp = TemperaturaRandom();
            MostrarEnForm(aux.ToString(), txt);
            Thread.Sleep(5000);
            if (aux.Temp >= 35 && aux.Temp <= 39)
            {
                contagiado.Invoke(aux);
            }

        }


        public void MostrarEnForm(string mensaje, TextBox txt)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate{
                    txt.Text = mensaje;
                });
            }
            else
            {
                txt.Text = mensaje;
            }
        }

        public void RefrescarLista()
        {
            if (listBoxContagiados.InvokeRequired)
            {
                listBoxContagiados.BeginInvoke((MethodInvoker)delegate
                {
                    listBoxContagiados.DataSource = null;
                    listBoxContagiados.DataSource = colaDeContagiados;
                });
            }
            else
            {
                listBoxContagiados.DataSource = null;
                listBoxContagiados.DataSource = colaDeContagiados;
            }
        }

        public void LlamarProximo(object textbox)
        {
            if (colaDePersonas.Count > 0)
            {
                //invocar al metodo
                //llamar a atender
                Atender((TextBox)textbox);
                //llamar al proximo
                proximo.Invoke(textbox);

            }
        }

        private void Contagiado(Persona p)
        {
            Thread.Sleep(4000);
            colaDeContagiados.Enqueue(p);
            RefrescarLista();

        }

        private void btnNuevaPersona_Click(object sender, EventArgs e)
        {
            NuevaPersona FrmNuevaPersona = new NuevaPersona(this);
            FrmNuevaPersona.ShowDialog();
        }

        private void btnAutom_Click(object sender, EventArgs e)
        {
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 1234)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 456789)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 54234)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 1248434)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 12344949)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 4551234)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 564541234)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 1235463)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 12354632)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 12312331)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 123130)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 4529)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 7828)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 78928)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 124533428)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 428)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 12133428)));
            colaDePersonas.Enqueue((new Persona(numeroAumenta++, 78945)));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {

            IniciarHilos();

        }

        public void IniciarHilos()
        {
            if (!t1.IsAlive)
            {
                t1.Start();
                Thread.Sleep(1000);
            }
            if (!t2.IsAlive)
            {
                t2.Start();
                Thread.Sleep(1000);
            }
            if (!t3.IsAlive)
            {
                t3.Start();
                Thread.Sleep(1000);
            }
            if (!t4.IsAlive)
            {
                t4.Start();
                Thread.Sleep(1000);
            }
            if (!t5.IsAlive)
            {
                t5.Start();
                Thread.Sleep(1000);
            }
            btnAtender.Click -= btnAtender_Click;
        }
    }
}
