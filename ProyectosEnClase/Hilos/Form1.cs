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
        Thread toolStrip;
        SqlConnection miConexion; //server, a que base me conecto y las credenciales
        SqlCommand miComando;
        List<string> notificaciones;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ParameterizedThreadStart(MostrarTiempo)); //se utiliza para indicarle al thread que se pasa un parametro
            toolStrip = new Thread(LlenarToolStripStatus);
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
                    //MessageBox.Show(sqlDr[0].ToString());
                    //MessageBox.Show(sqlDr[1].ToString());


                    notificaciones.Add(sqlDr[1].ToString());
                    //provincias.Add(new KeyValuePair<decimal, string>(decimal.Parse(sqlDr[0].ToString()), sqlDr[1].ToString()));

                }

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
            foreach (var item in notificaciones)
            {
                while (true)
                {
                    this.toolStripStatus.Text = item;
                    Thread.Sleep(5000);
                }
            }
            
        }

        private void MostrarTiempo(object utcObj) //debera si o si retornar void y recibir un objeto
        {
            int utc = (int)utcObj; //casteo objeto a int
            if (lblTiempo.InvokeRequired)
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


        private void GuardarTexto(string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(Environment.CurrentDirectory + "\\Mensaje.txt"))
                {
                    file.WriteLine(datos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            t.Start(-3); //le paso el parametro en el start
            toolStrip.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
        }
    }
}
