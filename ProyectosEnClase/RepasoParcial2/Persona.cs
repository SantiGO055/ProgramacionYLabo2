using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoParcial2
{
    public class Persona
    {
        private int numero;
        private int dni;
        private int temperatura;
        List<Persona> listaPersonas;

        public Persona()
        {

        }
        public Persona(int num, int dni)
        {
            Numero = num;
            Dni = dni;
            Temp = 0;
            listaPersonas = new List<Persona>();
        }


        public int Temp
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

    }
}
