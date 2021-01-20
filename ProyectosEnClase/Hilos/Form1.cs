using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class Form1 : Form
    {

        Thread t;
        Thread toolStripThread;
        SqlConnection miConexion; //server, a que base me conecto y las credenciales
        SqlCommand miComando;
        List<string> notificaciones;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ParameterizedThreadStart(MostrarTiempo)); //se utiliza para indicarle al thread que se pasa un parametro
            toolStripThread = new Thread(LlenarToolStripStatus);
            miConexion = new SqlConnection(@"Data Source = LCCTECNMJ669C42\SQLEXPRESS; Initial Catalog = Hilos; Integrated Security = True;");
            miComando = new SqlCommand();
            notificaciones = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                miConexion.Open();

                miComando.Connection = miConexion; //asigno al command la conexion creada con la base
                miComando.CommandText = "select * from Mensajes"; //paso la consulta a la base
                SqlDataReader sqlDr = miComando.ExecuteReader();


                while (sqlDr.Read())
                {
                    notificaciones.Add(sqlDr[1].ToString());
                }
                toolStripThread.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
        }

        private void LlenarToolStripStatus()
        {

            while (notificaciones.Count == 6)
            {
                foreach (var item in notificaciones)
                {
                    this.toolStripStatus.Text = item;
                    Thread.Sleep(5000);
                }
            }
        }

        private void MostrarTiempo(object utcObj) //debera si o si retornar void y recibir un objeto
        {
            int utc = (int)utcObj; //casteo objeto a int
            while (true)
            {
                if (lblTiempo.InvokeRequired) // verifico si el objeto que viene por parametro viene de otro hilo y hace falta invocarlo
                {
                    lblTiempo.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblTiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("hh:MM:ss");
                    });
                }
                else
                {
                    lblTiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("hh:MM:ss");
                }
                Thread.Sleep(1000);
            }
        }


        private void GuardarTexto(List<string> datos) // recibo la lista si quiero guardar toda la lista al txt, sino recibo el string del status strip
        {
            try
            {
                using (StreamWriter file = new StreamWriter(Environment.CurrentDirectory + "\\Mensaje.txt"))
                {
                    foreach (var item in datos) //foreach de la lista
                    {
                        
                        file.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!(t.IsAlive))
            {
                t.Start(-3); //le paso el parametro en el start
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
            if (toolStripThread.IsAlive)
                toolStripThread.Abort();
        }

        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            GuardarTexto(notificaciones);
        }

        private void toolStripStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
