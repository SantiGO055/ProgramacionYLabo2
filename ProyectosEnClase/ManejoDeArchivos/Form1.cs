using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pathApp = AppDomain.CurrentDomain.BaseDirectory + "miArchivoDeForm.txt";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //string pathApp = AppDomain.CurrentDomain.BaseDirectory + "miArchivoDeForm.txt";
            using (StreamWriter sw = new StreamWriter(pathApp))
            {
                sw.Write(rtbTexto.Text);
                lblResultadoGuardar.Text = "Archivo guardado correctamente";
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(pathApp))
            {
                string line;
                StringBuilder sb = new StringBuilder();
                while ((line = sr.ReadLine()) != null) //el enter no es un null
                {
                    
                    sb.AppendLine(line);
                }
                rtbLeer.Text = sb.ToString();
                lblResultadoLeer.Text = "Archivo leido correctamente";
            }

        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            rtbTexto.Clear();
            rtbLeer.Clear();
            lblResultadoGuardar.Text = "";
            lblResultadoLeer.Text = "";
        }

        private void btnLeerArchivoProfe_Click(object sender, EventArgs e)
        {
            
            using (StreamReader sr = new StreamReader(@"C:\Users\ins03\Documents\GitHub\ProgramacionYLabo2\ProyectosEnClase\ManejoDeArchivos\bin\Debug\PruebaProfe.txt"))
            {
                string line;
                StringBuilder sb = new StringBuilder();
                while ((line = sr.ReadLine()) != null) //el enter no es un null
                {
                    sb.AppendLine(line);
                }
                rtbLeer.Text = sb.ToString();
                lblResultadoLeer.Text = "Archivo leido correctamente";
            }
        }
    }
}
