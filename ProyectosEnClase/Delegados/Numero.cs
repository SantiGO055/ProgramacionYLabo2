using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados
{
    public delegate void EnCero(object sender);
    public class Numero
    {
        //public event EnCero
        private TextBox txtMostrado;
        private int valor;
        private int velocidad;

        public Numero()
        {
            Velocidad = 50;
            Valor = 100;
        }


        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public TextBox TxtMostrado
        {
            get { return txtMostrado; }
            set { txtMostrado = value; }
        }

        public int Velocidad
        {
            get { return velocidad; }
            set {
                if (velocidad<=0)
                {
                    throw new Exception("No se puede asignar velocidad menor a 0");
                }
                velocidad = value; 
            }
        }

        private void Descontar()
        {
            Valor--;
            while(Valor > 0)
            {
                Valor--;
                if (this.TxtMostrado.InvokeRequired)
                {
                    TxtMostrado.BeginInvoke((MethodInvoker)delegate (){

                    });
                    //
                }
                else
                {
                    TxtMostrado.Text = Valor.ToString();
                }
                Thread.Sleep(Velocidad);
            }
        }


    }
}
