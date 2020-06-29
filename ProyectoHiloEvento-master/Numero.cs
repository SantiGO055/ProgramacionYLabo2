using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QueNoLlegueACero
{

    public delegate void EnCero(object sender);

    public class Numero
    {

        public event EnCero LlegueACero;

        private TextBox txtMostrado;

        private int valor;

        private int velocidad;
        

        public int Velocidad
        {
            get { return velocidad; }
            set {
                if (value < 1)
                    throw new Exception("No se puede asignar velocidad menor a 0");
                velocidad = value;
            }
        }


        public int Valor
        {
            get { return valor; }
            set {

                if (value == 0 && LlegueACero.GetInvocationList() != null)
                    LlegueACero.Invoke(this);
                valor = value;

            }
        }


        public TextBox TxtMostrado
        {
            get { return txtMostrado; }
            set { txtMostrado = value; }
        }


        public Numero()
        {
            Velocidad = 50;
            Valor = 100;
        }

        public void Reset(object sender, EventArgs e)
        {
            Valor = 100;
            Velocidad = Velocidad-5;
        }

        public void Descontar() {

            while(Valor > 0 )
            {
                Valor--;
                if (this.txtMostrado.InvokeRequired)
                {
                    this.txtMostrado.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.txtMostrado.Text = Valor.ToString();
                    });
                }
                else
                {
                    this.txtMostrado.Text = Valor.ToString();
                }
                Thread.Sleep(Velocidad);
            }

        }
        
    }
}
