using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp6
{

    delegate void AnalizaPersona(Persona p);
    delegate void Atender(object o);

    public partial class Form1 : Form
    {
        const int TIEMPOCONTAGIADO = 3000;
        const int TIEMPOATEN = 1500;
        List<Thread> hilos;
        Queue<Persona> personas;
        List<Persona> contagiados;
        Random random;
        event AnalizaPersona TieneTemperatura;
        event Atender AtenderProximo;


        public Form1()
        {
            InitializeComponent();

            //inicializa las listas y el random
            hilos = new List<Thread>();
            personas = new Queue<Persona>();
            contagiados = new List<Persona>();
            random = new Random();

            //asigan los manejadores
            TieneTemperatura += llevarContagiado;
            AtenderProximo += proximo;

            // llena la lista
            llenarCola();
            llenarCola();
            llenarCola();
            llenarCola();

            #region fines didacticos
            /*
            System.EventHandler a = new EventHandler(segundon);
            a = (EventHandler)EventHandler.Combine(a, new EventHandler(button1_Click));
            a = (EventHandler)EventHandler.Combine(a, a);
            this.button1.Click +=  a; 

               private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
        private void segundon(object sender, EventArgs e)
        {
            MessageBox.Show("s");
        }
            */

            #endregion


        }

        void mostrarEnForm(string mensaje, TextBox txt)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate
               {
                   txt.Text = mensaje;
               });
            }
            else
                txt.Text = mensaje;

        }

        private void proximo(object textBox)
        {
            //si tiene personas pendientes, la atiende
            if (personas.Count > 0)
                Atender(personas.Dequeue(), (TextBox)textBox);
        }

        private void llevarContagiado(Persona p)
        {
            //espera el tiempo para que se lleven al contagiado
            Thread.Sleep(TIEMPOCONTAGIADO);
            //lo agrega a la lista
            contagiados.Add(p);
            // muestra en pantalla
            refrescarlista();
        }

        private void refrescarlista()
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.BeginInvoke((MethodInvoker)delegate
                {
                    listBox1.DataSource = null;
                    listBox1.DataSource = contagiados;
                });
            }
            else
            {
                listBox1.DataSource = null;
                listBox1.DataSource = contagiados;
            }
        }

        private void llenarCola()
        {
            personas.Enqueue(new Persona("Prangnell", 321321231));
            personas.Enqueue(new Persona("Spinks", 14244242424));
            personas.Enqueue(new Persona("Emblin", 155555555));
            personas.Enqueue(new Persona("Janzen", 16666516));
            personas.Enqueue(new Persona("Percy", 133131457));
            personas.Enqueue(new Persona("Dewan", 1512318));
            personas.Enqueue(new Persona("Sacaze", 16532429));
            personas.Enqueue(new Persona("Belleny", 2654540));
            personas.Enqueue(new Persona("Beckson", 2653532));
            personas.Enqueue(new Persona("Stitt", 23213213212));
            personas.Enqueue(new Persona("Conlon", 243262623));
            personas.Enqueue(new Persona("Fishbie", 3132132));
            personas.Enqueue(new Persona("Iveagh", 5674543));
            personas.Enqueue(new Persona("Robez", 22311136));
            personas.Enqueue(new Persona("Le Sarr", 267845437));
            personas.Enqueue(new Persona("Gheorghie", 286234242));
            personas.Enqueue(new Persona("Kopfer", 22132132149));
            personas.Enqueue(new Persona("Weeke", 332131560));
            personas.Enqueue(new Persona("Hamon", 316546542));
            personas.Enqueue(new Persona("Seif", 328653));
            personas.Enqueue(new Persona("Mussalli", 338638653));
            personas.Enqueue(new Persona("Kleinsmuntz", 33567254));
            personas.Enqueue(new Persona("Guymer", 1543534678));
            personas.Enqueue(new Persona("Bogaert", 42342366623));
            personas.Enqueue(new Persona("Carletto", 5434643543));
            personas.Enqueue(new Persona("Grishukov", 364363212));
            personas.Enqueue(new Persona("Moggan", 111333355));
            personas.Enqueue(new Persona("Emlin", 43215678));
            personas.Enqueue(new Persona("Kinnock", 477658561));
            personas.Enqueue(new Persona("Newcomb", 908768768));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agrega la persona a la lista
            personas.Enqueue(new Persona(txtNombre.Text, long.Parse(txtDNI.Text)));
        }

        void Atender(Persona persona, TextBox txt)
        {
            // le asigna la temperatura
            persona.Temperatura = (decimal)(random.Next(350, 390) )/ 10;
            // muestra la persona en el textbox 
            mostrarEnForm(persona.ToString(), txt);
            // Espera el tiempo
            Thread.Sleep(TIEMPOATEN);
            if (persona.Temperatura > (decimal)37.5)
            {
                //si esta enfermo lanza el evento  
                TieneTemperatura(persona);
            }
            mostrarEnForm("", txt);
            //Lanza el evento que llama al proximo
            AtenderProximo(txt);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Elimino los hilos si aun existen
            foreach (Thread item in hilos)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (hilos.Count != 5)
            {
                //Agrego los hilos a la lista
                Thread t = new Thread(new ParameterizedThreadStart(proximo));
                hilos.Add(t);
                hilos.Add(new Thread(new ParameterizedThreadStart(proximo)));
                hilos.Add(new Thread(new ParameterizedThreadStart(proximo)));
                hilos.Add(new Thread(new ParameterizedThreadStart(proximo)));
                hilos.Add(new Thread(new ParameterizedThreadStart(proximo)));
            }

            //Inicio los hilos si no están andando

            if (!hilos[0].IsAlive)
            {
                hilos[0] = new Thread(new ParameterizedThreadStart(proximo));
                hilos[0].Start(txtPuesto1);
            }
            if (!hilos[1].IsAlive)
            {
                hilos[1] = new Thread(new ParameterizedThreadStart(proximo));
                hilos[1].Start(txtPuesto2);
            }
            if (!hilos[2].IsAlive)
            {
                hilos[2] = new Thread(new ParameterizedThreadStart(proximo));
                hilos[2].Start(txtPuesto3);
            }
            if (!hilos[3].IsAlive)
            {
                hilos[3] = new Thread(new ParameterizedThreadStart(proximo));
                hilos[3].Start(txtPuesto4);
            }
            if (!hilos[4].IsAlive)
            {
                hilos[4] = new Thread(new ParameterizedThreadStart(proximo));
                hilos[4].Start(txtPuesto5);
            }
        }

        private void txtPuesto1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
